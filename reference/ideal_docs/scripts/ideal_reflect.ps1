# ideal.exe — .NET Reflection Analizi
$ErrorActionPreference = "Stop"
$asmPath = "D:\iDeal\ideal.exe"
$outDir  = "D:\Projects\_secfix\ideal_analysis"
New-Item -ItemType Directory -Force -Path $outDir | Out-Null

# 1) Bağımlı DLL'leri yükle
Get-ChildItem "D:\iDeal\*.dll" | ForEach-Object {
    try { [System.Reflection.Assembly]::ReflectionOnlyLoadFrom($_.FullName) | Out-Null } catch {}
}

# 2) Ana assembly yükle
$asm = [System.Reflection.Assembly]::ReflectionOnlyLoadFrom($asmPath)
"Assembly: $($asm.FullName)" | Out-File "$outDir\00_assembly_info.txt"
"Versiyon : $($asm.GetName().Version)" | Out-File "$outDir\00_assembly_info.txt" -Append

# 3) Tipleri al (ReflectionTypeLoadException'dan kurtar)
$allTypes = @()
try {
    $allTypes = @($asm.GetTypes())
} catch {
    try {
        $rtle = [System.Reflection.ReflectionTypeLoadException]$_.Exception
        $allTypes = @($rtle.Types | Where-Object { $_ -ne $null })
    } catch {
        # InnerException yolu
        $allTypes = @($_.Exception.InnerException.Types | Where-Object { $_ -ne $null })
    }
}

"Toplam tip : $($allTypes.Count)" | Out-File "$outDir\00_assembly_info.txt" -Append
Write-Host "Toplam tip: $($allTypes.Count)"

# 4) Namespace bazında özet
$nsSummary = $allTypes | Group-Object { $_.Namespace } | Sort-Object Count -Descending
$nsSummary | ForEach-Object { "$($_.Count.ToString().PadLeft(5))  $($_.Name)" } |
    Out-File "$outDir\01_namespace_summary.txt"
Write-Host "Namespace ozeti yazildi."

# 5) Tüm sınıf/enum/interface listesi
$allTypes | Sort-Object FullName | ForEach-Object {
    $kind = if ($_.IsEnum) { "enum" } elseif ($_.IsInterface) { "interface" } elseif ($_.IsValueType) { "struct" } else { "class" }
    "$kind`t$($_.FullName)"
} | Out-File "$outDir\02_all_types.txt"
Write-Host "Tip listesi yazildi."

# 6) Veri modeli sınıfları — public field/property içerenler (Form ve Control harici)
$dataTypes = $allTypes | Where-Object {
    -not $_.IsEnum -and
    -not ($_.FullName -match "^System\.") -and
    ($_.GetFields([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance).Count -gt 0 -or
     $_.GetProperties([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance).Count -gt 2)
}

$sb = [System.Text.StringBuilder]::new()
foreach ($t in ($dataTypes | Sort-Object FullName)) {
    [void]$sb.AppendLine("=== $($t.FullName) ===")
    # Fields
    try {
        $fields = $t.GetFields([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance -bor [System.Reflection.BindingFlags]::Static)
        foreach ($f in ($fields | Sort-Object Name)) {
            [void]$sb.AppendLine("  [FIELD]  $($f.FieldType.Name) $($f.Name)")
        }
    } catch {}
    # Properties
    try {
        $props = $t.GetProperties([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance)
        foreach ($p in ($props | Sort-Object Name)) {
            [void]$sb.AppendLine("  [PROP]   $($p.PropertyType.Name) $($p.Name)")
        }
    } catch {}
    [void]$sb.AppendLine("")
}
$sb.ToString() | Out-File "$outDir\03_data_models.txt" -Encoding UTF8
Write-Host "Veri modelleri yazildi."

# 7) Enum tanımları (tüm değerler)
$enums = $allTypes | Where-Object { $_.IsEnum }
$enumSb = [System.Text.StringBuilder]::new()
foreach ($e in ($enums | Sort-Object FullName)) {
    [void]$enumSb.AppendLine("enum $($e.FullName)")
    try {
        $names  = [System.Enum]::GetNames($e)
        $names | ForEach-Object { [void]$enumSb.AppendLine("    $_") }
    } catch {
        # ReflectionOnly bağlamında GetNames çalışmaz, manuel al
        $fields = $e.GetFields() | Where-Object { $_.IsLiteral }
        $fields | ForEach-Object { [void]$enumSb.AppendLine("    $($_.Name)") }
    }
    [void]$enumSb.AppendLine("")
}
$enumSb.ToString() | Out-File "$outDir\04_enums.txt" -Encoding UTF8
Write-Host "Enum listesi yazildi."

# 8) Statik sabit string alanları (const/public static readonly string)
$constSb = [System.Text.StringBuilder]::new()
foreach ($t in $allTypes) {
    try {
        $consts = $t.GetFields([System.Reflection.BindingFlags]::Public -bor 
                               [System.Reflection.BindingFlags]::NonPublic -bor
                               [System.Reflection.BindingFlags]::Static) |
                  Where-Object { $_.IsLiteral -and $_.FieldType -eq [string] }
        foreach ($c in $consts) {
            [void]$constSb.AppendLine("$($t.FullName).$($c.Name)")
        }
    } catch {}
}
$constSb.ToString() | Out-File "$outDir\05_string_consts.txt" -Encoding UTF8
Write-Host "String sabitler yazildi."

Write-Host ""
Write-Host "=== TAMAMLANDI ==="
Write-Host "Cikti dizini: $outDir"
Get-ChildItem $outDir | ForEach-Object { Write-Host "  $($_.Name) ($([math]::Round($_.Length/1KB,1)) KB)" }
