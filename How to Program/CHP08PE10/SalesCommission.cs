using System;

public class SalesCommission
{
    private int[] commissions;

    public SalesCommission()
    {

    }

    public SalesCommission(int[] commissions)
    {
        Commissions = commissions;
    }

    public int[] Commissions { get => commissions; set => commissions = value; }

    public void ProcessSalesCommission()
    {
        DisplayMessage();
        ProcessBarChart();
    }

    private void DisplayMessage()
    {
        Console.WriteLine("Getting sales commission data!");
    }

    public void ProcessBarChart()
    {
        int[] frequency = new int[11];

        foreach (int commission in Commissions)
        {
            if ((((int)(commission * .09) / 100) + 2) >= 10)
                ++frequency[10];
            else
                ++frequency[((int)(commission * .09) / 100) + 2];
        }

        for (int i = 2; i <= 10; i++)
        {
            if (i == 10)
                Console.Write("  $1000: ");
            else
                Console.Write("${0:D2}-{1:D2} ", (i * 100), (i * 100) + 99);

            for (int stars = 0; stars < frequency[i]; ++stars)
                Console.Write("*");

            Console.WriteLine();
        }

    }

}
