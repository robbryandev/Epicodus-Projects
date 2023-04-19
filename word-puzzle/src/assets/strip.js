import * as fs from "fs"

const words = fs.readFileSync("./words.txt", "utf-8").split("\n")
const rx = /^[a-z]{6}$/gi
const newWords = words.filter(w => w.match(rx) != null)
const wordJson = JSON.stringify({words: newWords})
fs.writeFileSync("./new_words.json", wordJson)