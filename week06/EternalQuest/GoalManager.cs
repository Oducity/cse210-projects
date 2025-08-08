using System.ComponentModel.Design;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
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
        if (typeOfGoal == "1")
        {
            ListGoalNames();
            ListGoalDetails();
        }
        else if (typeOfGoal == "2")
        {
            SimpleGoal simpleGoal = new SimpleGoal();
            string newName = ListGoalNames();
            simpleGoal.SetName(newName);
            string description = ListGoalDetails();
            simpleGoal.SetDescription(description);
        }
        else if (typeOfGoal == "3")
        {
            string name = ListGoalNames();
            string description = ListGoalDetails();
            string simpleGoal = $"{name}, {description}";

        }
    }
    public void DisplayPlayerInfo()
    {

    }

    public string ListGoalNames()
    {
        
        Console.Write("What is the name of goal? ");
        string nameReply = Console.ReadLine();
        return $"{nameReply}";
    }

    public string ListGoalDetails()
    {
        Console.Write("What is a short description of it? ");
        string descriptionReply = Console.ReadLine();
        return $"{descriptionReply}";
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

