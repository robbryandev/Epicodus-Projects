using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using GalleryGram.ResponseModels;
using System.ComponentModel.DataAnnotations;

namespace GalleryGram.Models
{
    public class Address
    {
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string postalOrZipCode { get; set; }
        public string countryCode { get; set; }
        public string townOrCity { get; set; }
        public string stateOrCounty { get; set; }
    }

    public class Asset
    {
        public string printArea { get; set; }
        public string url { get; set; }
    }

    public class Item
    {
        public string sku { get; set; }
        public int copies { get; set; }
        public string sizing { get; set; }
        public List<Asset> assets { get; set; }
    }

    public class Recipient
    {
        public Address address { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }

    public class OrderRequest
    {
        public string shippingMethod { get; set; }
        public Recipient recipient { get; set; }
        public List<Item> items { get; set; }

        public static async Task<OrderResponse> Post(Address address, Asset asset, string userName, string userEmail)
        {
          OrderRequest order = new OrderRequest();
          order.items = new List<Item>();
          order.shippingMethod = "Budget";
          order.recipient = new Recipient();
          order.recipient.address = address;
          order.recipient.name = userName;
          order.recipient.email = userEmail;

          // Asset asset = new Asset() {
          //   printArea = "default",
          //   url = "https://your-image-url/image.png" // Change to selected image!
          // };

          Item item = new Item() { 
            sku = "GLOBAL-FAP-8x10", // Product
            copies = 1, // User can select copies in future?
            sizing = "fillPrintArea",
            assets = new List<Asset>()
          };
          item.assets.Add(asset);

          order.items.Add(item);

          string jsonOrder = JsonConvert.SerializeObject(order);
          RestResponse jsonResponse = await ApiHelper.Post(jsonOrder);

          OrderResponse response = JsonConvert.DeserializeObject<OrderResponse>(jsonResponse.Content);

          return response;
        }
    }
}