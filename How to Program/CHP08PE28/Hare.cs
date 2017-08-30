using System;

public class Hare
{
    private Random randNum;

    public Hare()
    {
        randNum = new Random();
    }

    public int Run()
    {
        return MoveType(randNum.Next(10));
    }

    private int MoveType(int moveType)
    {
        switch (moveType)
        {
            case 0:
            case 1:
                Console.Write("Hare went to sleep!");
                return 0;
            case 2:
            case 3:
                Console.Write("Hare made a big hop!");
                return 9;
            case 4:
                Console.Write("Hare made a big slip!");
                return -12;
            case 5:
            case 6:
            case 7:
                Console.Write("Hare made a small hop!");
                return 1;
            default:
                Console.WriteLine("Hare made a small slip!");
                return -2;
        }
    }
}