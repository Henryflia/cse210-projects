using System;

    public class Files : Goals{
        private string _fileName = "";
        protected List<string> _goals = new List<string>();
        public Files(){
            _fileName = "";
        }
        public Files(string name){
            _fileName = name;
        }
        public void SaveFile(){
            Console.Write("What is the name of the file? ");
            string fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
            foreach (string goal in _goals)
            {
                outputFile.WriteLine(goal);
            }
        }
        }
        public void LoadFile(){
            Console.Write("What is the name of the file? ");
            string fileName = Console.ReadLine();
            using (StreamReader inputFile = new StreamReader(fileName))
                {
                    string line;
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        _goals.Add(line);
                    }
                }
                }
        public void AddGoals(string goal){
            _goals.Add(goal);
        }
        public List<string> AllGoals(){
            return _goals;
        }
        public void ListGoals(){
            foreach (string goal in _goals){
                string[] list = goal.Split(",");
                if(list[0] == "SimpleGoal"){
                    if(list[4]== "False")
                        {
                            Console.WriteLine($"[ ] {list[1]} - ({list[2]})");
                        }
                    else
                        {
                            Console.WriteLine($"[X] {list[1]} - {list[2]}");
                        }

                }
                else if(list[0] == "EternalGoal"){
                        Console.WriteLine($"[ ] {list[1]} - ({list[2]})");
                }
                else if(list[0] == "CheckListGoal"){
                        if(list[6] != list[7]){
                            Console.WriteLine($"[ ] {list[1]}  ({list[2]}) --- Currently completed: {list[6]}/{list[7]}");
                        }
                        else{
                            Console.WriteLine($"[X] {list[1]}  ({list[2]}) --- Currently completed: {list[6]}/{list[7]}");
                        }
                }
            }
        }
        public void RecordEventFIles(string goal, int choice)
        {   
            _goals[choice] = goal;
        }
        public int AddPoint(int point){
            point = 0;
            foreach(string goals in _goals){
                string[] list = goals.Split(",");
                if(list[0] == "SimpleGoal" && list[4] == "True"){
                    point += int.Parse(list[3]);
                }
                else if(list[0] == "EternalGoal" && list[4] == "True"){
                    list[5] = (int.Parse(list[5]) + 1).ToString();
                    point += int.Parse(list[3]) * int.Parse(list[5]);
                }
                else if(list[0] == "CheckListGoal" && list[4] == "True"){
                    point += int.Parse(list[3]) * int.Parse(list[6]);
                    if(list[6] == list[7]){
                        point += int.Parse(list[5]);
                    }   
                }
            }
            return point;

        }
    } 
