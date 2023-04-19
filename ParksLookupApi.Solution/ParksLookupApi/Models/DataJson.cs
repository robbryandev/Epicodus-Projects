using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ParksLookupApi.Models {
    public class DataJson {
      public List<State> states {get; set;}
      public List<Park> parks {get; set;}

      public DataJson()
      {
        List<State> stateList = new List<State>();
        List<Park> parkList = new List<Park>();

        string dataString = File.ReadAllText("data/data.json");
        JObject datajson = JObject.Parse(dataString);

        IList<JToken> stateResults = datajson["states"].Children().ToList();
        foreach (JToken result in stateResults)
        {
            State newState = result.ToObject<State>();
            stateList.Add(newState);
        }

        IList<JToken> parkResults = datajson["parks"].Children().ToList();
        foreach (JToken result in parkResults)
        {
            Park newPark = result.ToObject<Park>();
            parkList.Add(newPark);
        }

        states = stateList;
        parks = parkList;
      }
    }
}