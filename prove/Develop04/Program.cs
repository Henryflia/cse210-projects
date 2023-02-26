using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        int reflects = 0;
        int breaths = 0;
        int lists = 0;
        while(choice!= 5){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Amount of Display Activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if(choice == 1){
                BreathingActivity breath = new BreathingActivity("breath in...", "Now breath out...", "Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on yout breathing.");
                breath.RunActivity();
                int userb = breath.GetCountDown();
                int time = breath.GetTime();
                breath.StartMessage();
                breath.DisplaytheBreathing(userb);
                breath.DisplayEndMessage(time);

                breaths += 1;
            }
            else if(choice == 2){
                ReflectionActivity reflect = new ReflectionActivity("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflect.RunActivity();
                int userr = reflect.GetCountDown();
                int time = reflect.GetTime();
                reflect.RunPrompt();
                reflect.StartMessage();
                reflect.ShowQuestions(userr);
                reflect.DisplayEndMessage(time);
                reflects += 1;
                

            }
            else if(choice == 3){
                ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.RunActivity();
                int userl = listing.GetCountDown();
                int time = listing.GetTime();
                listing.StartMessage();
                listing.DisplayPrompts();
                listing.EnterAnswer(userl);
                listing.DisplayEndMessage(time);
                lists += 1;
            }
            else if(choice == 4)
            {
                Console.WriteLine("Amount of Displays: ");
                Console.WriteLine($"Breathing Activity: {breaths}");
                Console.WriteLine($"Breathing Activity: {reflects}");
                Console.WriteLine($"Breathing Activity: {lists}");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }
            else if(choice == 4)
            {
                break;
            }
        }

        

    }
}