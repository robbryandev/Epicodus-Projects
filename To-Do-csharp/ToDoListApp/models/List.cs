namespace ToDo
{
    public enum TaskOptions {
        ADD = 0,
        VIEW = 1,
        CLOSE = 2
    }
    public class List
    {
        public static List<string> ToDo  {get; set;} = new List<string>();
        public static void Add(string input) {
            ToDo.Add(input);
        }
        public static void View(){
            foreach(string i in ToDo){
                Console.WriteLine(i);
            }
        }
    }
}