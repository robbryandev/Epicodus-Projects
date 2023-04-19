import strutils
import csvtools
import states

type Park* = object
  park_id*: int
  state_id*: int
  name*: string

proc newPark*(name, park_id: string, state_id: int): Park =
  result.name = name.multiReplace(
    (" *", ""),
    (" ", ""),
    ("–", "-"),
    ("ʻ", "'")
  )
  result.park_id = park_id.parseInt() + 1
  result.state_id = state_id

proc getAllParks*(stateList: seq[State]): seq[Park] =
  var allParks: seq[Park] = @[]
  var parkFirst = true
  for parkRow in csvRows("./ParkData.csv"):
    if parkFirst:
      parkFirst = false
      continue
    for state in stateList:
      if parkRow[3].contains(state.name):
        # name, park_id, state_id
        allParks.add(newPark(parkRow[1], parkRow[0], state.state_id))
        echo "Added " & parkRow[1] & " as a " & state.name & " park"
        break
  return allParks