using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 10.7 (Complex Numbers) 
 * Create a class called Complex for performing arithmetic with complex numbers. Complex numbers have the 
 * form realPart + imaginaryPart * i where i is square root of -1. Write an app to test your class. Use floating-point 
 * variables to represent the private data of the class. Provide a constructor that enables an object of 
 * this class to be initialized when it’s declared. Provide a parameterless constructor with default values 
 * in case no initializers are provided. Provide public methods that perform the following operations:
 *      a) Add two Complex numbers: The real parts are added together and the imaginary parts are added together.
 *      b) Subtract two Complex numbers: The real part of the right operand is subtracted from the real part 
 *              of the left operand, and the imaginary part of the right operand is subtracted from the 
 *              imaginary part of the left operand.
 *      c) Return a string representation of a Complex number in the form (a, b), where a is the real 
 *              part and b is the imaginary part.
 */
namespace CHP10PE07
{
    class Complex
    {
        private float realPart;
        private float imaginaryPart;

        public Complex(float realPart = 10.345f, float imaginaryPart = 0.0f)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        public Complex(Complex c) : this(c.realPart, c.imaginaryPart) { }

        public float RealPart { get => realPart; set => realPart = value; }
        public float ImaginaryPart { get => imaginaryPart; set => imaginaryPart = value; }

        public String Add(Complex c)
        {
            float real = this.realPart + c.realPart;
            float imaginary = this.imaginaryPart + c.imaginaryPart;

            if (imaginary >= 0)
                return (real + " + " + imaginary + "i");
            else
                return (real + " " + imaginary + "i");
        }

        static void Main(string[] args)
        {
            Complex num1 = new Complex(12.2f, 3.1f);
            Complex num2 = new Complex(4.7f, 0.1f);

            Console.WriteLine(num1.Add(num2));
        }
    }
}
