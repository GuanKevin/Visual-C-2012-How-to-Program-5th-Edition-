using System;

public class Tortoise
{
    private Random randNum;

    public Tortoise()
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
            case 2:
            case 3:
            case 4:
                Console.Write("The tortoise made a fast plod!");
                return 3;
            case 5:
            case 6:
                Console.Write("The tortoise had a slip!");
                return -6;
            default:
                Console.Write("The tortoise made a slow plod!");
                return 1;
        }
    }
}