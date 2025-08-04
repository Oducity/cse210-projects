using System.ComponentModel;

public class ReflectionActivity : BreathingActivity
{
    private List<string> _promptQuestions = new List<string>() { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?", "How did the glory of the Lord reflect in this experience" };
    private List<string> _promptText = new List<string>() { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private List<int> _questionsIndexes = new List<int>();
    private List<int> _textIndexes = new List<int>();
    private int _duration;
    private int _timeSpent;

    public ReflectionActivity(string activityName, string description, string preparationMessage, string endMessage) : base(activityName, description, preparationMessage, endMessage)
    {

    }

    public void GetRandomReflection()
    {
        _duration = GetDuration();
        _timeSpent = GetTimeSpent();
        while (_questionsIndexes.Count < _promptQuestions.Count && _duration > _timeSpent)
        {
            Random rand = new Random();
            //pick text index value
            int randIndex = rand.Next(_promptText.Count);
            //return the text at the picked index
            string text = _promptText[randIndex];
            Console.Write("Consider the following prompt:" + Environment.NewLine + "---" + text + "---" + Environment.NewLine + "When you have something in mind, press enter to continue.");

            Console.ReadKey();
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");
            PauseTimer2();
            Console.WriteLine("");
            do
            {
                //if ()
                GetRandomQuestion();
            } while (_promptQuestions.Count() < _questionsIndexes.Count() && _duration > _timeSpent);

        }

    }
    

    public void GetRandomQuestion()
    {
        Random random = new Random();


        //Compare the numbers of items in _questionsIndexes with the numbers of items in _promptQuestions
        while (_questionsIndexes.Count() < _promptQuestions.Count())
        {

            _duration = GetDuration();
            _timeSpent = GetTimeSpent();
            int questionIndex = random.Next(_promptQuestions.Count);
            do
            {
                _timeSpent = GetTimeSpent();
                string question = _promptQuestions[questionIndex];
                //PauseTimer();
                Console.Write($"---{question}---");
                //Thread.Sleep(1000);
                DisplaySpinner();
                Console.WriteLine("");
                _questionsIndexes.Add(questionIndex);
            } while (!_questionsIndexes.Contains(questionIndex) && _duration > _timeSpent);

        }

    }

}