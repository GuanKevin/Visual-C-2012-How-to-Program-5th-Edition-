using System;

public class Craps
{
    private int playAmount;

    public Craps() : this(1000) { }
    public Craps(int playAmount)
    {
        PlayAmount = playAmount;
    }

    public int PlayAmount { get => playAmount; set => playAmount = value; }

    public void PlayCrapsStatistic()
    {
        DisplayMessage();
    }



    private void DisplayMessage()
    {
        Console.WriteLine("Lets play {0} of Craps!", PlayAmount);
    }
}