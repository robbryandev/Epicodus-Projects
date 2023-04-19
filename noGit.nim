import std/[os, strutils]

for i in os.walkDirs("./*"):
    for f in os.walkDirs(i & "/*"):
        echo "found " & f
        if f.endsWith(".git"):
            echo "removing " & f
            os.removeDir(f)

