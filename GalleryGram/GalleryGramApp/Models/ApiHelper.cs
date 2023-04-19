using RestSharp;
using GalleryGram.Keys;

namespace GalleryGram.Models
{
  public class ApiHelper
  {
    public static async Task<RestResponse> Post(string newOrder)
    {
      RestClient client = new RestClient("https://api.sandbox.prodigi.com/v4.0");
      RestRequest request = new RestRequest($"/Orders", Method.Post);
      request.AddHeader("X-API-Key", EnvironmentVariables.ApiKey);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newOrder);
      RestResponse response = await client.PostAsync(request);

      return response;
    }
  }
}