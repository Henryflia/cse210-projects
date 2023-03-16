using System;

    public class Goals{
        protected string _name = "";
        protected string _description = "";
        protected int _points;
        protected string _goal = "";


        public Goals()
        {

        }
        public Goals(string name, string description, int point)
        {
            _name = name;
            _description = description;
            _points = point;

        }
        public string GetName(){
            return _name;
        }
        public string GetDescription(){
            return _description;
        }
        public string GetGoal(){
            return _goal;
        }
        public int GetPoints(){
            return _points;
        }
        public virtual string SendGoal(){
            return "";
        }

        
        public virtual int GetScores(){
            return 0;
        }  
        public virtual string RecordEvent(string goal){
            return "";
        }
        public virtual string DisplayGoal(string name, string description){
            return "";
        }
        public virtual void DivideGoal(string[] goal){
        }
    }

