using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running(3,"3 Nov 2023", 30, "Running");
        run.GetDistance();
        run.GetSpeed();
        run.GetPace();
        run.StringList();
        
        Swimming swim = new Swimming(30,"3 Nov 2023", 10, "Swimming");
        swim.GetDistance();
        swim.GetSpeed();
        swim.GetPace();
        swim.StringList();

        Cycling cycle = new Cycling("3 Nov 2023", 6.0, 20, "Cycling");
        cycle.GetDistance();
        cycle.GetSpeed();
        cycle.GetPace();
        cycle.StringList();

        run.SaveInTheList(run.StringList());
        run.SaveInTheList(cycle.StringList());
        run.SaveInTheList(swim.StringList());
        run.GetSummary();
    }
}