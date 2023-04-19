namespace ToDo
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to the To Do List");
            bool quit = false;
            while (!quit) {
                quit = AskMode();
            }
        }
        
        public static bool AskMode() {
            Console.WriteLine("Would you like to add an item to your list or view/close your list? (Add/View)Close");
            string? askInput = Console.ReadLine();
            string[] askArray = askInput.Split(' ', 2);
            List<string> askList = new List<string>{};
            foreach (string a in askArray) {
                askList.Add(a);
            }
            string userInput = askArray[0] != null ? askArray[0] : "close";
            object modeObj = new Object();
            int mode = 2;
            if (askArray.Length == 1) {
                askList.Add("");
            }
            bool isMode = Enum.TryParse(typeof(TaskOptions), askArray[0], true, out modeObj);
            if (isMode) {
                mode = (int)Enum.Parse(typeof(TaskOptions), askArray[0].ToUpper());
            }
            RunMode(mode, askList[1]);
            return !isMode || mode == 2;
        }

        public static void RunMode(int mode, string chicken) {
            if(mode == 0) {
                List.Add(chicken);
            } else if(mode == 1) {
                List.View();
            }
        }
    }
}