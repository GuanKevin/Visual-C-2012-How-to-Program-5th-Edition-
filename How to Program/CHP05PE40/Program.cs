using System;

/**
 * 5.40 (World Population Growth) 
 * World population has grown considerably over the centuries. Continued growth could eventually challenge the limits of 
 * breathable air, drinkable water, arable cropland and other limited resources. There’s evidence that growth has been slowing 
 * in recent years and that world population could peak some time this century, then start to decline. Write a program that 
 * calculates world population growth each year for the next 75 years, using the simplifying assumption that the current growth 
 * rate will stay constant. When displaying the results, the first column should display the year from year 1 to year 75. The 
 * second column should display the anticipated world population at the end of that year. The third column should display the 
 * numerical increase in the world population that would occur that year. Using your results, determine the year in which the 
 * population would be double what it is today, if this year’s growth rate were to persist. [Hint: Use double variables because 
 * int variables can store values only up to approximately two billion. Display the double values using the format F0.]
 */
namespace CHP05PE40
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldPopulation = 7512888100;
            int yearCounter = 0;
            double growthRate = 0;
            Console.WriteLine("Year\tWorld_Population\tGrowth");
            Boolean findDouble = false;

            while(++yearCounter <= 75)
            {
                growthRate = worldPopulation * 0.0111;
                worldPopulation += growthRate;
                Console.WriteLine("{0}{1, 21 :F2}{2, 20 :F2}", yearCounter, worldPopulation, growthRate);

                if (!findDouble)
                {
                    if ((7512888100 * 2) <= worldPopulation)
                    {
                        Console.WriteLine("World population will double in year {0}.", yearCounter);
                        findDouble = true;
                    }
                }
            }
        }
    }
}
