import os, json
import states, parks

let states: seq[State] = getAllStates()
let parks: seq[Park] = getAllParks(states)

echo "states with parks: " & $states.len()
echo "total parks: " & $parks.len()

var outputJson = newJObject()

outputJson.add("states", newJArray())
for state in states:
  outputJson["states"].add(%*state)

outputJson.add("parks", newJArray())
for park in parks:
  outputJson["parks"].add(%*park)

writeFile("./data.json", outputJson.pretty())