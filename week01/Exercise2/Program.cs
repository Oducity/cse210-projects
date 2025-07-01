using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        string letter = "";
        string remark = "";
        //string sign = "";


        Console.Write("What is your grade percentage in number? Don't include percent symbol! ");

        float score = float.Parse(Console.ReadLine());

        if (score >= 70)
        {

            if (score >= 90)
            {
                if (score >= 97)
                {
                    letter = "A+";
                }
                else
                {
                    letter = "A";
                }
            }

            else if (score >= 80)
            {
                letter = "B";

                if (score >= 87)
                {
                    letter = "B+";
                }
                else if (score < 83)
                {
                    letter = "B-";
                }
            }

            else
            {
                letter = "C";

                if (score >= 77)
                {
                    letter = "C+";
                }
                else if (score < 73)
                {
                    letter = "C-";
                }
            }
            remark = "Congratulations, you passed!";
        }

        else
        {
            if (score >= 60)
            {
                letter = "D";

                if (score >= 67)
                {
                    letter = "D+";
                }
                else if (score < 63)
                {
                    letter = "D-";
                }
            }

            else
            {
                letter = "F";
            }

            remark = "Haven't gone this far, with little more effort you're going to make it next term.";
        }

        Console.WriteLine($"{remark} Your grade is: {letter}");
        
    }
}