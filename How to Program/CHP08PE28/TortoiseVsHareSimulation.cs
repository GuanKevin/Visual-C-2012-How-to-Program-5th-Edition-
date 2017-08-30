using System;

public class TortoiseVsHareSimulation
{
    private Tortoise tortoise;
    private Hare hare;
    private int raceTrackLength;

    public TortoiseVsHareSimulation() : this(new Tortoise(), new Hare(), 70) {}

    public TortoiseVsHareSimulation(Tortoise tortoise, Hare hare, int raceTrackLength)
    {
        this.Tortoise = tortoise;
        this.Hare = hare;
        this.RaceTrackLength = raceTrackLength;
    }

    public void StartRace()
    {
        int tortoisePosition = 0;
        int harePosition = 0;

        Console.WriteLine("Hare{0, 55}", "Tortoise");
        while (tortoisePosition < raceTrackLength && harePosition < raceTrackLength)
        {
            harePosition += hare.Run();
            Console.Write("{0, 30}", "");
            tortoisePosition += tortoise.Run();
            Console.WriteLine();
            System.Threading.Thread.Sleep(250);
        }

        if (tortoisePosition > harePosition)
            Console.WriteLine("The tortoise has won the race!");
        else
            Console.WriteLine("The hare has won the race!");
    }

    public Tortoise Tortoise { get => tortoise; set => tortoise = value; }
    public Hare Hare { get => hare; set => hare = value; }
    public int RaceTrackLength { get => raceTrackLength; set => raceTrackLength = value; }
}