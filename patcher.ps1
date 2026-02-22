git reset --hard origin/main
git show 90b0574 -- . ":!src/crash_log.txt" > p1.patch; git apply p1.patch; git add -A; git commit -C 90b0574
git show 916ee98 -- . ":!src/crash_log.txt" > p2.patch; git apply p2.patch; git add -A; git commit -C 916ee98
git show e9d84ab -- . ":!src/crash_log.txt" > p3.patch; git apply p3.patch; git add -A; git commit -C e9d84ab
git show 46dcd34 -- . ":!src/crash_log.txt" > p4.patch; git apply p4.patch; git add -A; git commit -C 46dcd34
echo "src/crash_log.txt" >> .gitignore
git add .gitignore
git commit -m "chore: ignore large crash_log.txt"
git push
