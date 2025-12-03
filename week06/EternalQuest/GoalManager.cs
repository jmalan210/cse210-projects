using System.Configuration.Assemblies;
using System.IO;
using System.IO.Enumeration;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Eternal Quest Goal Game!\n\n");
        DisplayPlayerInfo();

        while (true)
        {
            Console.WriteLine("Please select one of the following options:\n1.Create a new goal\n2.List goals\n3.Save goals\n4.Load goals\n5.Record event\n6.Quit\n");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }

            else if (choice == "2")
            {
                ListGoalNames();
            }

            else if (choice == "3")
            {
                SaveGoals();
            }

            else if (choice == "4")
            {
                LoadGoals();
            }

            else if (choice == "5")
            {
                Console.WriteLine("The goals are:");
                int i = 1;
                foreach (Goal g in _goals)
                {
                    g.GetName();
                    i++;
                }
                Console.WriteLine("Which goal did you accomplish?");
                RecordEvent();
            }

            else if (choice == "6")
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter a choice from 1-6");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        
        Console.Write($"You have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        if (_goals.Count < 1)
        {
            Console.WriteLine("No goals to display");
            return;
        }
        int i = 1;
        foreach (Goal g in _goals)
        {
            string name = g.GetName();
            string description = g.GetDescription();
            string checkbox = "[ ]";

            if (g.IsComplete() == true)
            {
                checkbox = "[X]";
            }
            Console.Write($"{checkbox} {i}. {name} ({description}) ");

            if (g is ChecklistGoal)
            {
                Console.WriteLine(g.GetDetailsString());
            }

            i++;
        }
    }

    public void CreateGoal()
    {
        while (true)
        {
            Console.Write("What type of goal would you like to create?\n1.Simple Goal\n2.Eternal Goal\n3.Checklist Goal\n");
            string goalChoice = Console.ReadLine();

            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();

            Console.WriteLine("Give a short description of your goal:");
            string description = Console.ReadLine();

            Console.WriteLine("How many points are associated with this goal?");
            int points = int.Parse(Console.ReadLine());

            if (goalChoice == "1")
            {
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
            }

            else if (goalChoice == "2")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }

            else if (goalChoice == "3")
            {
                Console.WriteLine("How many times does this goal need to be completed to earn a bonus?");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("How many bonus points will you earn for completing this target?");
                int bonusPoints = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonusPoints);
                _goals.Add(checklistGoal);
            }

            else
            {
                Console.WriteLine("Invalid input.  Please select a number from 1-3");
                
            }
            return;
           
        }
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the file name? (*.txt)");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }

        }
    }
    
    public void LoadGoals()
    {
        
    }
}