using GalleryGram.Models;

namespace GalleryGram.ResponseModels
{
    public class Address
    {
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string postalOrZipCode { get; set; }
        public string countryCode { get; set; }
        public string townOrCity { get; set; }
        public object stateOrCounty { get; set; }
    }

    public class Asset
    {
        public string id { get; set; }
        public string printArea { get; set; }
        public string md5Hash { get; set; }
        public string url { get; set; }
        public string status { get; set; }
    }

    public class Attributes
    {
        public string color { get; set; }
    }

    public class Details
    {
        public string downloadAssets { get; set; }
        public string printReadyAssetsPrepared { get; set; }
        public string allocateProductionLocation { get; set; }
        public string inProduction { get; set; }
        public string shipping { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string status { get; set; }
        public string merchantReference { get; set; }
        public string sku { get; set; }
        public int copies { get; set; }
        public string sizing { get; set; }
        public Attributes attributes { get; set; }
        public List<Asset> assets { get; set; }
        public RecipientCost recipientCost { get; set; }
    }

    public class Metadata
    {
        public string mycustomkey { get; set; }
        public SomeCustomerPreference someCustomerPreference { get; set; }
        public int sourceId { get; set; }
    }

    public class Order
    {
        public string id { get; set; }
        public DateTime created { get; set; }
        public DateTime lastUpdated { get; set; }
        public object callbackUrl { get; set; }
        public string merchantReference { get; set; }
        public string shippingMethod { get; set; }
        public object idempotencyKey { get; set; }
        public Status status { get; set; }
        public List<object> charges { get; set; }
        public List<object> shipments { get; set; }
        public Recipient recipient { get; set; }
        public List<Item> items { get; set; }
        public object packingSlip { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Recipient
    {
        public string name { get; set; }
        public object email { get; set; }
        public object phoneNumber { get; set; }
        public Address address { get; set; }
    }

    public class RecipientCost
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class OrderResponse
    {
        public string outcome { get; set; }
        public Order order { get; set; }
        public string traceParent { get; set; }
    }

    public class SomeCustomerPreference
    {
        public string preference1 { get; set; }
        public string preference2 { get; set; }
    }

    public class Status
    {
        public string stage { get; set; }
        public List<object> issues { get; set; }
        public Details details { get; set; }
    }
}