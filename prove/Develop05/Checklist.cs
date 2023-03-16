using System;

    public class Checklist : Goals{
        private int _timesToComplete;
        private int _timesCompleted;
        private int _bonus;

        public Checklist(string name, string description, int points, int bonus, int timesToComplete, int timesCompleted): base(name, description, points){
            _timesCompleted = timesCompleted;
            _timesToComplete = timesToComplete;
            _bonus = bonus;
            _goal = "CheckListGoal";
        }
        
        public override string RecordEvent(string goall)
        {  
            char s = ',';
            string[] list = goall.Split(s);
            list[4] = "True";
            int times = int.Parse(list[6]) + 1;
            list[6] = $"{times}";
            string m = string.Join(s.ToString(), list);
            return m;
        }
        public int GetTimetoComplete(){
            return _timesToComplete;
        }
        public int GetTimeCompleted(){
            return _timesCompleted;
        }
        public int GetBonus(){
            return _bonus;
        }
        public override string SendGoal()
        {
            string name = GetName();
            string description = GetDescription();
            string goalname= GetGoal();
            int points = GetPoints();
            int timesCompleted = GetTimeCompleted();
            int timesToComplete = GetTimetoComplete();
            int bonus = GetBonus();
            string complete = "False";

            return $"{goalname},{name},{description},{points},{complete},{bonus},{timesCompleted},{timesToComplete}";
        }
    }
