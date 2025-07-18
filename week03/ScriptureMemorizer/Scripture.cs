using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();


    public Scripture()
    {

    }

    public void HideRandomWords()
    {

    }
    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}