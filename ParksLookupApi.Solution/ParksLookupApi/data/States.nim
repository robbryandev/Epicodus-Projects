import strutils
import csvtools

type State* = object
  state_id*: int
  name*: string
  park_count*: int

proc newState(name, state_id, park_count: string): State =
  result.state_id = state_id.parseInt() + 1
  result.name = name
  result.park_count = park_count.parseInt()

proc getAllStates*(): seq[State] =
  var allStates: seq[State] = @[]

  var stateFirst = true
  for stateRow in csvRows("./StateData.csv"):
    if stateFirst:
      stateFirst = false
      continue
    # name, id, park_count
    allStates.add(newState(stateRow[1], stateRow[0], stateRow[2]))
    echo "Added " & stateRow[1] & " to the states list"
  return allStates