namespace BakeryMVCApp.Models {
    public class Vendor {
        private static int? currentId {get; set;}
        public int id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public List<Order> Orders {get; set;} = new List<Order>{};
        private static List<Vendor> _instances {get; set;} = new List<Vendor>{};

        public Vendor(string name, string description) {
            if (currentId == null) {
                currentId = 0;
            } else {
                currentId++;
            }
            id = (int)currentId;
            Name = name;
            Description = description;
            _instances.Add(this);
        }

        public static List<Vendor> GetAll() {
            return _instances;
        }

        public static void ClearAll() {
            currentId = -1;
            _instances = new List<Vendor>{};
        }
    }
}