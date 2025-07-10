public class Greeting
{


    public Greeting()
    {

    }


    public void GreetingTime()
    {
        DateTime currentTime = DateTime.Now;
        int hour = currentTime.Hour;


        if (hour < 12)
        {
            Console.WriteLine("Good Morning, Welcome To The Journal App!");
        }

        else if (hour < 17)
        {
            Console.WriteLine("Good Afternoon, Welcome To The Journal App!");
        }

        else if (hour < 19)
        {
            Console.WriteLine("Good Evening, Welcome To The Journal App!");
        }

        else
        {
            Console.WriteLine("It Is Night, Please Record Your Journal If You Could.");
        }
    }

    public void GoodBye()
    {
        Console.WriteLine("Goodbye!");
    }
}