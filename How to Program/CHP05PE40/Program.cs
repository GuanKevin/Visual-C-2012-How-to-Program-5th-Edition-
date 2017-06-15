using System;

/**
 * 5.40 (World Population Growth) World population has grown considerably over the centuries. Continued growth could 
 * eventually challenge the limits of breathable air, drinkable water, arable cropland and other limited resources. There’s 
 * evidence that growth has been slowing in recent years and that world population could peak some time this century, then 
 * start to decline. For this exercise, research world population growth issues online. Be sure to investigate various 
 * viewpoints. Get estimates for the current world population and its growth rate (the percentage by which it is likely 
 * to increase this year). Write a program that calculates world population growth each year for the next 75 years, using 
 * the simplifying assumption that the current growth rate will stay constant. When displaying the results, the first 
 * column should display the year from year 1 to year 75. The second column should display the anticipated world 
 * population at the end of that year. The third column should display the numerical increase in the world population 
 * that would occur that year. Using your results, determine the year in which the population would be double what it is 
 * today, if this year’s growth rate were to persist. [Hint: Use double variables because int variables can 
 * store values only up to approximately two billion. Display the double values using the format F0.]
 */
namespace CHP05PE40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter current world population: ");
            double worldPopulation = Convert.ToDouble(Console.ReadLine());
            double doublePopulationCheck = worldPopulation * 2;
            Boolean yearDoubles = true;
            int yearCounter = 1;
            Console.WriteLine("Year\tAnticipated_World_Population\tEstimated_Population_Growth");

            while (yearCounter <= 75)
            {
                double populationGrowth = worldPopulation * 0.011;
                Console.WriteLine("{0}\t{1:F0}\t\t\t{2:F0}", yearCounter++, worldPopulation, populationGrowth);

                if (yearDoubles)
                    if (doublePopulationCheck <= worldPopulation)
                    {
                        Console.WriteLine("World population is doubled this year.");
                        yearDoubles = false;
                    }

                worldPopulation += populationGrowth;
            }
        }
    }
}
