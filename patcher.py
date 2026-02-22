import os

def run(cmd):
    print(f"Running: {cmd}")
    os.system(cmd)

run('git reset --hard origin/main')

commits = ["90b0574", "916ee98", "e9d84ab", "46dcd34"]

for i, commit in enumerate(commits):
    patch = f"p{i}.patch"
    run(f'git show {commit} -- . ":!src/crash_log.txt" > {patch}')
    run(f'git apply {patch}')
    run('git add -A')
    run(f'git commit -C {commit}')

with open('.gitignore', 'a', encoding='utf-8') as f:
    f.write('\nsrc/crash_log.txt\n')

run('git add .gitignore')
run('git commit -m "chore: ignore large crash_log.txt"')
run('git push')
