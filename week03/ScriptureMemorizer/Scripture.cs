using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private string _referenceNumber;
    private string _scriptureQuote;
    private Reference _reference;
    private List<Word> _words;
    private Random _random;


    public Scripture(Reference reference, string passage)
    {
        _reference = reference;
        _words = passage.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    



    public void HideRandomWords()
    {
        var notHidden = _words.Where(word => !word.IsHidden()).ToList();

        if (notHidden.Count > 0)
        {
            int index = _random.Next(notHidden.Count);
            notHidden[index].Hide();
        }

    }
    public string GetDisplayText()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetReference());
        Console.Clear();
        string display = string.Join(' ', _words.Select(word => word.GetDisplayText()));
        Console.WriteLine($"{display}");
        return display;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}