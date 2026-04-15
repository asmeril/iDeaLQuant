// iDeal icinde calisacak robot listesi export scripti
// Amac: aktif robot tanimlarini process icinden CSV'ye yazmak

var ExportYolu = "D:\\iDeal\\robot_list_live.csv";

var Flags = System.Reflection.BindingFlags.Public |
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Static |
            System.Reflection.BindingFlags.Instance;

var sb = new System.Text.StringBuilder();
sb.AppendLine("__Meta__;Key;Value");

var idealAsm = (System.Reflection.Assembly)null;
foreach (var asm in System.AppDomain.CurrentDomain.GetAssemblies())
{
    if (asm.GetName().Name == "ideal")
    {
        idealAsm = asm;
        break;
    }
}

if (idealAsm == null)
{
    sb.AppendLine("meta;Error;ideal assembly process icinde bulunamadi");
    System.IO.File.WriteAllText(ExportYolu, sb.ToString(), System.Text.Encoding.UTF8);
    Sistem.Mesaj("ideal assembly bulunamadi. Dosya yazildi: " + ExportYolu);
}
else
{
    object bestList = null;
    string bestSource = "";
    int bestCount = -1;

    // 1) Tum *Setting* class'lari tara: static Setting + instance RoboTradeList
    foreach (var t in idealAsm.GetTypes())
    {
        if (t.Name.IndexOf("Setting") < 0)
            continue;

        var settingFld = t.GetField("Setting", Flags);
        var listFld = t.GetField("RoboTradeList", Flags);
        if (settingFld == null || listFld == null)
            continue;

        var deserializeMethod = t.GetMethod("Deserialize", Flags);
        object settingObj = null;

        try
        {
            settingObj = settingFld.GetValue(null);
        }
        catch
        {
        }

        if (settingObj == null && deserializeMethod != null)
        {
            try
            {
                deserializeMethod.Invoke(null, null);
                settingObj = settingFld.GetValue(null);
            }
            catch
            {
            }
        }

        object candidateList = null;
        int candidateCount = -1;

        if (settingObj != null)
        {
            try
            {
                candidateList = listFld.GetValue(settingObj);
                var en = candidateList as System.Collections.IEnumerable;
                if (en != null)
                {
                    int temp = 0;
                    foreach (var x in en)
                        temp++;
                    candidateCount = temp;
                }
            }
            catch
            {
            }
        }

        sb.AppendLine("scan;" + t.FullName + ";" + candidateCount.ToString());

        if (candidateCount > bestCount)
        {
            bestCount = candidateCount;
            bestList = candidateList;
            bestSource = t.FullName + ".Setting.RoboTradeList";
        }
    }

    // 2) Fallback: ideal.RoboTradeClass.IslemList
    var roboType = idealAsm.GetType("ideal.RoboTradeClass");
    if (roboType != null)
    {
        var islemListFld = roboType.GetField("IslemList", Flags);
        if (islemListFld != null)
        {
            int islemCount = -1;
            object islemObj = null;

            try
            {
                islemObj = islemListFld.GetValue(null);
                var en2 = islemObj as System.Collections.IEnumerable;
                if (en2 != null)
                {
                    int temp2 = 0;
                    foreach (var y in en2)
                        temp2++;
                    islemCount = temp2;
                }
            }
            catch
            {
            }

            sb.AppendLine("scan;ideal.RoboTradeClass.IslemList;" + islemCount.ToString());

            if (islemCount > bestCount)
            {
                bestCount = islemCount;
                bestList = islemObj;
                bestSource = "ideal.RoboTradeClass.IslemList";
            }
        }
    }

    // 3) Genis tarama: tum type'larda static IslemList alanlarini tara
    foreach (var tAll in idealAsm.GetTypes())
    {
        var fld = tAll.GetField("IslemList", Flags);
        if (fld == null)
            continue;

        // Sadece static alanlar
        if (!fld.IsStatic)
            continue;

        int fldCount = -1;
        object fldObj = null;

        try
        {
            fldObj = fld.GetValue(null);
            var enFld = fldObj as System.Collections.IEnumerable;
            if (enFld != null)
            {
                int temp3 = 0;
                foreach (var z in enFld)
                    temp3++;
                fldCount = temp3;
            }
        }
        catch
        {
        }

        sb.AppendLine("scan;" + tAll.FullName + ".IslemList;" + fldCount.ToString());

        if (fldCount > bestCount)
        {
            bestCount = fldCount;
            bestList = fldObj;
            bestSource = tAll.FullName + ".IslemList";
        }
    }

    sb.AppendLine("meta;Source;" + bestSource);

    var enumerable = bestList as System.Collections.IEnumerable;
    if (enumerable == null || bestCount <= 0)
    {
        // 4) Son fallback: acik formlardan robot gridlerini oku
        var formCount = 0;
        var gridFound = false;
        var gridRowCount = 0;
        var pickedGridName = "";

        sb.AppendLine("meta;Info;Liste kaynagi bos, grid taramasi basliyor");

        foreach (System.Windows.Forms.Form frm in System.Windows.Forms.Application.OpenForms)
        {
            formCount++;
            sb.AppendLine("form;" + frm.Name + ";" + frm.Text);

            System.Windows.Forms.Control gridCtrl = null;
            string[] candidateNames = new string[]
            {
                "gridRobotPosition",
                "gridRobotOrder",
                "gridMagnus",
                "gridRoboTrade"
            };

            int bestLocalRows = -1;

            foreach (var cname in candidateNames)
            {
                try
                {
                    var foundCtrls = frm.Controls.Find(cname, true);
                    if (foundCtrls != null && foundCtrls.Length > 0)
                    {
                        var candidateCtrl = foundCtrls[0];
                        int localRows = -1;

                        var candidateDgv = candidateCtrl as System.Windows.Forms.DataGridView;
                        if (candidateDgv != null)
                        {
                            int r = 0;
                            foreach (System.Windows.Forms.DataGridViewRow rr in candidateDgv.Rows)
                            {
                                if (rr != null && !rr.IsNewRow)
                                    r++;
                            }
                            localRows = r;
                        }

                        if (localRows > bestLocalRows)
                        {
                            bestLocalRows = localRows;
                            gridCtrl = candidateCtrl;
                            pickedGridName = cname;
                        }
                    }
                }
                catch
                {
                }
            }

            if (gridCtrl == null)
            {
                // Tehis: Portfoy formunda olasi grid/robo kontrollerini tara
                if (frm.Name == "formPortfolio" || frm.Text.IndexOf("Portf", System.StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    var stack = new System.Collections.ArrayList();
                    foreach (System.Windows.Forms.Control root in frm.Controls)
                        stack.Add(root);

                    while (stack.Count > 0)
                    {
                        var idx = stack.Count - 1;
                        var c = (System.Windows.Forms.Control)stack[idx];
                        stack.RemoveAt(idx);

                        var cName = c.Name == null ? "" : c.Name;
                        var cType = c.GetType().FullName;

                        if (cName.IndexOf("robo", System.StringComparison.OrdinalIgnoreCase) >= 0 ||
                            cName.IndexOf("grid", System.StringComparison.OrdinalIgnoreCase) >= 0 ||
                            cType.IndexOf("grid", System.StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            sb.AppendLine("ctrl;" + frm.Name + ";" + cName + ";" + cType);
                        }

                        foreach (System.Windows.Forms.Control ch in c.Controls)
                            stack.Add(ch);
                    }
                }

                continue;
            }

            gridFound = true;
            sb.AppendLine("meta;GridSource;OpenForms." + frm.Name + "." + pickedGridName);

            // DataGridView ise satirlari yaz
            var dgv = gridCtrl as System.Windows.Forms.DataGridView;
            if (dgv != null)
            {
                var header = new System.Text.StringBuilder();
                header.Append("grid;__RowType__");
                foreach (System.Windows.Forms.DataGridViewColumn col in dgv.Columns)
                    header.Append(";" + col.Name);
                sb.AppendLine(header.ToString());

                foreach (System.Windows.Forms.DataGridViewRow row in dgv.Rows)
                {
                    if (row == null || row.IsNewRow)
                        continue;

                    gridRowCount++;
                    var line = new System.Text.StringBuilder();
                    line.Append("grid;DataGridViewRow");

                    foreach (System.Windows.Forms.DataGridViewColumn col in dgv.Columns)
                    {
                        object cellVal = null;
                        try
                        {
                            cellVal = row.Cells[col.Index].Value;
                        }
                        catch
                        {
                            cellVal = "<ERR>";
                        }

                        var s = cellVal == null ? "" : cellVal.ToString();
                        s = s.Replace(";", ",").Replace("\r", " ").Replace("\n", " ");
                        line.Append(";" + s);
                    }

                    sb.AppendLine(line.ToString());
                }
            }
            else
            {
                sb.AppendLine("meta;Warn;grid bulundu ama DataGridView degil: " + pickedGridName + " => " + gridCtrl.GetType().FullName);
            }
        }

        sb.AppendLine("meta;OpenFormCount;" + formCount.ToString());
        sb.AppendLine("meta;GridFound;" + gridFound.ToString());
        sb.AppendLine("meta;GridRowCount;" + gridRowCount.ToString());
        sb.AppendLine("meta;PickedGrid;" + pickedGridName);

        if (!gridFound)
            sb.AppendLine("meta;Error;Robot grid kontrolu acik formlarda bulunamadi");

        System.IO.File.WriteAllText(ExportYolu, sb.ToString(), System.Text.Encoding.UTF8);
        Sistem.Mesaj("Liste bos oldugu icin grid fallback calisti. Grid satir: " + gridRowCount.ToString());
        Sistem.Mesaj("Dosya: " + ExportYolu);
    }
    else
    {
        System.Reflection.PropertyInfo[] props = null;
        int count = 0;

        foreach (var item in enumerable)
        {
            if (item == null)
                continue;

            count++;
            var tItem = item.GetType();

            if (props == null)
            {
                props = tItem.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                var header = new System.Text.StringBuilder();
                header.Append("row;__TypeName__");
                foreach (var p in props)
                    header.Append(";" + p.Name);
                sb.AppendLine(header.ToString());
            }

            var line = new System.Text.StringBuilder();
            line.Append("row;" + tItem.FullName);

            foreach (var p in props)
            {
                object val = null;
                try
                {
                    val = p.GetValue(item, null);
                }
                catch
                {
                    val = "<ERR>";
                }

                var s = val == null ? "" : val.ToString();
                s = s.Replace(";", ",").Replace("\r", " ").Replace("\n", " ");
                line.Append(";" + s);
            }

            sb.AppendLine(line.ToString());
        }

        sb.AppendLine("meta;Count;" + count.ToString());
        System.IO.File.WriteAllText(ExportYolu, sb.ToString(), System.Text.Encoding.UTF8);
        Sistem.Mesaj("Robot listesi export edildi. Kayit sayisi: " + count.ToString());
        Sistem.Mesaj("Kaynak: " + bestSource);
        Sistem.Mesaj("Dosya: " + ExportYolu);
    }
}
