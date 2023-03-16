using System;

class Program{
    static void Main(string[] args)
    {
        int choice = 0;
        int points = 0;
        int choice2 = 0;
        Files goal = new Files();
        Console.WriteLine("Welcome to this wonderful world, in which you can improve your skills, by setting goals and meeting them, come and start.");
        Console.Write("But before how many points do you want to get? ");
        int goalpoints = int.Parse(Console.ReadLine());
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

        while(choice!= 6){
            Console.Clear();
            if(points >= goalpoints){
                Console.Clear();
                Console.Write($"Wonderful, congratulations, hooray, you are the best, you have met your goal, keep it up and you will become great.");
                choice = 6;
                break;
            }
            Console.WriteLine(goalpoints);
            points = goal.AddPoint(points);
            Console.WriteLine($"You have {points} points");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if(choice == 1){
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Select a choice from the menu: ");
                choice2 = int.Parse(Console.ReadLine());
                if(choice2 == 1){
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with the goal? ");
                    int point = int.Parse(Console.ReadLine());
                    string complete = "False";
                    Simple simple = new Simple(name, description, point, complete);
                    goal.AddGoals(simple.SendGoal());
                    
                }
                else if(choice2 == 2){
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with the goal? ");
                    int point = int.Parse(Console.ReadLine());
                    Eternal eternal = new Eternal(name, description, point);
                    goal.AddGoals(eternal.SendGoal());
                }
                else if(choice2 == 3){
                    Console.Write("What is the name of your goal? ");
                    string name3 = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description3 = Console.ReadLine();
                    Console.Write("What is the amount of points associated with the goal? ");
                    int point3 = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be acomplished for a bonus? ");
                    int times = int.Parse(Console.ReadLine());
                    Console.Write("What si the bonus fot accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    Checklist check = new Checklist(name3, description3, point3, bonus, times, 0);
                    goal.AddGoals(check.SendGoal());

                }


            }
            else if(choice == 2){
                Console.Clear();
                Console.WriteLine("Your goals are:");
                Console.WriteLine();
                goal.ListGoals();
                Console.WriteLine();
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else if(choice == 3){
                goal.SaveFile();
            }
            else if(choice == 4)
            {
                goal.LoadFile();
            }
            else if(choice == 5)
            {   
                int number = 1;
                List<string> change = new List<string>(goal.AllGoals());
                foreach(string goall in change){
                    string[] list = goall.Split(",");
                    Console.WriteLine($"{number}. {list[0]}: {list[1]} ({list[2]})");
                    number ++;
                }
                
                Console.Write("What is your choce? ");
                int choice3 = int.Parse(Console.ReadLine());
                choice3 -= 1;
                string[] changegoal = {change[choice3]};
                foreach(string goall in changegoal){
                    string[] list = goall.Split(",");
                    foreach(string sss in list){
                    }
                    if(list[0] == "SimpleGoal"){
                        string name = list[1];
                        string description = list[2];
                        int point = int.Parse(list[3]);
                        string complete = list[4];
                        Simple simple = new Simple(name, description, point, complete);
                        // goal.RecordEvent(choice3);
                        if(list[4] == "False"){
                            string m = simple.RecordEvent(change[choice3]);
                            // Console.WriteLine(m);
                            goal.RecordEventFIles(m, choice3);
                            Console.WriteLine();
                            Console.WriteLine($"Excellent!!!!!, You did it !!!!! you won {list[3]} points");
                            points += int.Parse(list[3]);
                            Console.WriteLine();
                            Console.Write("Press ENTER to continue");
                            Console.ReadLine();
                        }
                        else{
                            Console.WriteLine();
                            Console.Write("You all ready completed this goal.");
                            Console.WriteLine();
                            Console.Write("Press ENTER to continue");
                            Console.ReadLine();
                        }
                    }
                    
                    else if(list[0] == "EternalGoal"){
                        string name = list[1];
                        string description = list[2];
                        int point = int.Parse(list[3]);
                        Eternal eternal = new Eternal(name, description, point);
                        if(list[4] == "False"){
                            string m = eternal.RecordEvent(change[choice3]);
                            Console.WriteLine(m);
                            goal.RecordEventFIles(m, choice3);
                            Console.WriteLine();
                            Console.WriteLine($"Excellent!!!!!, You did it !!!!! you won {list[3]} points");
                            points += int.Parse(list[3]);
                            Console.WriteLine();
                            Console.Write("Press ENTER to continue");
                            Console.ReadLine();
                        }
                    }
                    
                    if(list[0] == "CheckListGoal"){
                        string name = list[1];
                        string description = list[2];
                        int point = int.Parse(list[3]);
                        int bonus = int.Parse(list[5]);
                        int timesto = int.Parse(list[6]);
                        int timesco = int.Parse(list[7]) - 1;
                        Checklist check = new Checklist(name, description, point,bonus, timesto, timesco);
             
                        if(list[6] != list[7]){
                            string m = check.RecordEvent(change[choice3]);
                            goal.RecordEventFIles(m, choice3);
                            Console.WriteLine();

                            if(list[6] == (int.Parse(list[7])-1).ToString()){
                                Console.WriteLine($"Excellent!!!!!, You did it !!!!! you won {list[3]} points and a bonus of {list[5]} points");
                            }

                            else if(list[6] != (int.Parse(list[7])-1).ToString()){
                            Console.WriteLine($"Excellent!!!!!, You did it !!!!! you won {list[3]} points");
                            }
                            points += int.Parse(list[3]);
                            Console.WriteLine();
                            Console.Write("Press ENTER to continue");
                            Console.ReadLine();
                        }
                        else{
                            Console.WriteLine();
                            Console.Write("You all ready completed this goal.");
                            Console.WriteLine();
                            Console.Write("Press ENTER to continue");
                            Console.ReadLine();
                        }
                    }
                }
                }
            else if(choice == 6)
            {
                break;
            }
        }
    }
}

