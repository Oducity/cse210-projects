using System.ComponentModel.Design;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public void Start()
    {
        int menu = 0;
        while (menu < 1)
        {
            Console.WriteLine($"Menu Options:{Environment.NewLine}  1.  Create New Goal{Environment.NewLine}  2.  List Goals{Environment.NewLine}  3.  Save Goals{Environment.NewLine}  4.  Load Goals{Environment.NewLine}  5.  Record Event{Environment.NewLine}  6.  Quit");
            Console.Write("Select a choice from the menu: ");
            menu = Int32.Parse(Console.ReadLine());
        }
        if (menu == 1)
        {

        }
    }

    public void DisplayPlayerInfo()
    {

    }

    public string ListGoalNames()
    {
        return "";
    }

    public string ListGoalDetails()
    {
        return "";
    }

    public void CreateGoal()
    {

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

