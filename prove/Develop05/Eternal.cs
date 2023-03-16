using System;

    public class Eternal : Goals
    {
        
        public Eternal(string name, string description, int points) : base(name, description, points){
            _goal = "EternalGoal";
        }

        
        public override string RecordEvent(string goall)
        {  
            
            char s = ',';
            string[] list = goall.Split(s);
            list[4] = "True";
            int times = int.Parse(list[5]) + 1;
            list[5] = $"{times}";
            string m = string.Join(s.ToString(), list);
            // Console.WriteLine(m);
            return m;
        }
        public override string SendGoal()
        {
            string name = GetName();
            string description = GetDescription();
            string goalname= GetGoal();
            int points = GetPoints();
            string complete = "False";
            int times = 0;

            return $"{goalname},{name},{description},{points},{complete},{times}";
        }
    }