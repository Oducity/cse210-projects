using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Working with a List Project.");

        List<float> number = new List<float>();

        float total = 0; //initialize sum to 0.
        float average = 0;//initialize average to 0.
        float largest = 0;//initialize largest to 0.
        float numberCount = 0;//initialize number items to zero.
        float lowest = 1000000000;


        int yourNumber = 1; //initialize user input to 0.
        while (yourNumber != 0) //loop to get user input
        {
            Console.Write("Enter a list of positive and negative numbers and type 0 when finished. ");//get user input.
            yourNumber = int.Parse(Console.ReadLine());//convert user input from tring to float.

            if (yourNumber > 0)// determine which input is to be added to list.
            {
                number.Add(yourNumber);
            }
        }
        //loop to iterat through the list
        foreach (float item in number)
        {
            total += item;//update the sum of all numbers in the list.
            numberCount += 1; //stores the total numbers of items in the list.
            //Added if statement to get the largest number.
            if (item > largest)
            {
                largest = item;//updated largest number here.
            }
            //Added if statement to get the lowest positive number.
            if (item > 0 && item < lowest)
            {
                lowest = item;//update lowest positive number.
            }
        }
        average = total / numberCount;//Compute average number.
        Console.WriteLine($"The Sum is: {total}");
        Console.WriteLine($"The aversge is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The lowest positive number is: {lowest}");

    }
}