using System;

    public class Simple : Goals{
        private string _complete = "False";


        public Simple(){
            _complete = "False";
        }
        public Simple(string name, string description, int points, string complete) : base (name, description, points){
            _complete = complete;
            _goal = "SimpleGoal";
        }
        
        public override string RecordEvent(string goall)
        {  
            
            char s = ',';
            string[] list = goall.Split(s);
            list[4] = "True";
            string m = string.Join(s.ToString(), list);
            // Console.WriteLine(m);
            return m;
        }
        public override string SendGoal()
        {
            string name = GetName();
            string description = GetDescription();
            string goalname = GetGoal();
            int points = GetPoints();
            return $"{goalname},{name},{description},{points},{_complete}";
        }
        
    }
