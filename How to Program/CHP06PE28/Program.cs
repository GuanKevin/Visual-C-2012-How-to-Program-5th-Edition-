using System;

/**
 * 6.28 (Global Warming Facts Quiz) 
 * The controversial issue of global warming has been widely publicized by the film An  Inconvenient Truth, featuring 
 * former Vice President Al Gore. Mr. Gore and a U.N. network of scientists, the Intergovernmental Panel on Climate 
 * Change, shared the 2007 Nobel Peace Prize in recognition of “their efforts to build up and disseminate greater 
 * knowledge about man-made climate change.” Research both sides of the global warming issue online (you might want to 
 * search for phrases like “global warming skeptics”). Create a five-question multiple choice quiz on global warming, 
 * each question having four possible answers (numbered 1–4). Be objective and try to fairly represent both sides of the 
 * issue. Next, write an app that administers the quiz, calculates the number of correct answers (zero through five) and 
 * returns a message to the user. 
 * If the user correctly answers five questions, display “Excellent”; 
 * if four, display “Very good”; 
 * if three or fewer, display “Time to brush up on your knowledge of global warming,” 
 * and include a list of some of the websites where you found your facts.
 */ 
namespace CHP06PE28
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.Write("Check out link below to see list of question and answers!" +
                "\nhttps://www.exploringnature.org/graphics/quiz/glocal_warm_MultipleChoice.pdf" +
                "\n\n1. Earth’s temperatures are stable because we are surrounded by ________ " +
                "\nwhich allows the right amount of sunlight in to warm the Earth." +
                "\nA a cloud layer" +
                "\nB an atmosphere" +
                "\nC gravity" +
                "\nD water" +
                "\nEnter answer: ");

            if (Char.ToLower(Convert.ToChar(Console.Read())) == 'b')
                score++;
            Console.ReadLine();

            Console.Write("\n2. This layer keeps us “not too hot in the summer” and “not too cold in the winter.” " +
                "\nScientists call this the ________ effect" +
                "\nA greenhouse effect" +
                "\nB seasonal effect" +
                "\nC ocean effect" +
                "\nD lake effect" +
                "\nEnter answer: ");
            
            if (Char.ToLower(Convert.ToChar(Console.Read())) == 'a')
                score++;
            Console.ReadLine();

            Console.Write("\n3. Certain gases in the atmosphere – water vapor, carbon dioxide, methane and nitrous " +
                "\noxide– help maintain the Earth’s temperatures and climate. These are called: __________." +
                "\nA ozone gases" +
                "\nB solar gases" +
                "\nC greenhouse gases" +
                "\nD stomach gases" +
                "\nEnter anwser: ");

            if (Char.ToLower(Convert.ToChar(Console.Read())) == 'c')
                score++;
            Console.ReadLine();

            Console.Write("\n4. The solar energy that warms the Earth includes visible light, infrared and _____ " +
                "\ncoming from the sun. " +
                "\nA gamma rays" +
                "\nB ultraviolet radiation" +
                "\nC microwaves" +
                "\nD sunspots" +
                "\nEnter answer: ");

            if (Char.ToLower(Convert.ToChar(Console.Read())) == 'b')
                score++;
            Console.ReadLine();

            Console.Write("\n5. The solar radiation that bounces off the Earth back toward the atmosphere is mostly " +
                "\n_____ (with a longer wavelength). " +
                "\nA gamma radiation " +
                "\nB x - ray radiation" +
                "\nC nuclear radiation" +
                "\nD infrared radiation" +
                "\nEnter answer: ");

            if (Char.ToLower(Convert.ToChar(Console.Read())) == 'd')
                score++;
            Console.ReadLine();

            if (score == 5)
                Console.Write("\nExcellent!");
            else if (score == 4)
                Console.WriteLine("\nVery Good!");
            else
                Console.WriteLine("\nTime to brush up on your knowledge of global warming!");
        }
    }
}
