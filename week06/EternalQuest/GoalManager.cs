using System.ComponentModel.Design;
using System.Reflection;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    public GoalManager()
    {

    }
    //private int _score;
    public void Start()
    {
        int menu = 0;
        while (menu != 6)
        {
            Console.WriteLine($"Menu Options:{Environment.NewLine}  1.  Create New Goal{Environment.NewLine}  2.  List Goals{Environment.NewLine}  3.  Save Goals{Environment.NewLine}  4.  Load Goals{Environment.NewLine}  5.  Record Event{Environment.NewLine}  6.  Quit");
            Console.Write("Select a choice from the menu: ");
            menu = Int32.Parse(Console.ReadLine());
            if (menu == 1)
            {
                CreateGoal();
            }
            else if (menu == 2)
            {
                ListGoalNames();
            }
            else if (menu == 3)
            {
                SaveGoal();
            }
            else if (menu == 4)
            {
                SaveGoal();
            }
            else if (menu == 5)
            {
                RecordEvent();
            }
        }

    }

    public void CreateGoal()
    {
        string typeOfGoal;
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine($"  1. Simple Goal{Environment.NewLine}  2.  Eternal Goal{Environment.NewLine}  3.  Checklist Goal");
        Console.Write("Which typ of goal would you like to create? ");
        typeOfGoal = Console.ReadLine();

        if (typeOfGoal == "1")  // condition for SimpleGoal and its entries.
        {
            string name;
            string description;
            int points;

            Console.Write("What is the name of the goal? ");
            name = Console.ReadLine();// take the name of simple goals.

            Console.Write("What is a short description of this goal? ");
            description = Console.ReadLine(); // takes the description of simple goals.

            points = EnterGoalPoints(); //takes the associated points of simple goals.

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);//Create an object of simple goals.
            _goals.Add(simpleGoal); // Add created simple goals to list of goals.
        }
        else if (typeOfGoal == "2") // Condition for EternalGoal class.
        {
            string name;
            string description;
            int points;

            Console.Write("What is the name of the goal? ");
            name = Console.ReadLine();// take the name of Eternal goals.

            Console.Write("What is a short description of this goal? ");
            description = Console.ReadLine(); // takes the description of Eternal goals.

            points = EnterGoalPoints(); //takes the associated points of Eternal goals.

            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);//Add Created Eternal goal to list of goals.
        }
        else if (typeOfGoal == "3")// Condition for CheckListGoal class.
        {
            string name;
            string description;
            int points;
            int target;
            int bonus;

            Console.Write("What is the name of the goal? ");
            name = Console.ReadLine();// take the name of Eternal goals.

            Console.Write("What is a short description of this goal? ");
            description = Console.ReadLine(); // takes the description of Eternal goals.

            points = EnterGoalPoints(); //takes the associated points of Eternal goals.

            Console.Write("What is the target number of times for this goal? ");
            target = Int32.Parse(Console.ReadLine());

            Console.Write("What is the Bonus point at completion of the number times of this goal? ");
            bonus = Int32.Parse(Console.ReadLine());

            CheckListGoal checkListGoal = new CheckListGoal(name, description, points, target, bonus);
            _goals.Add(checkListGoal);

        }
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int numbering = 0;
        //int bonus = 0;
        
        foreach (Goal goal in _goals)
        {
            numbering += 1;

            string check;
            bool isComplete = goal.IsComplete();
            if (isComplete == true)
            {
                check = "[X]";
            }
            else
            {
                check = "[]";
            }
            Console.WriteLine($"  {numbering}: {check} {goal.GetName()} ({goal.GetDescription()})");
        }

    }
    public void DisplayPlayerInfo()
    {

    }

    public string ListGoalDetails()
    {
        return "";
    }

    public int EnterGoalPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoint = Int32.Parse(Console.ReadLine());
        return goalPoint;
    }

    public void RecordEvent()
    {

    }

    public void SaveGoal()
    {

    }

    public void LoadGoal()
    {

    }
}

