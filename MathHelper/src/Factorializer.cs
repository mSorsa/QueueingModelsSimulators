using MathHelper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.src;

public class Factorializer : IFactorializer
{
    private readonly factHelper helper;
    
    // ctor
    public Factorializer() { helper = new(); }

    
    /// <summary>
    /// Calculates the factorial of a number.
    /// Factorial is the product of all positive integers (non-zero) less than or equal to number.
    /// I.e.: 5! = 5 * 4 * 3 * 2 * 1 = 120
    /// </summary>
    /// <param name="number">Number to Factorialize.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public int Factorial(int number)
    {
        // Verify number can be factorialized ( 0 <= number <= 12 )
        helper.validateNumber(number);

        int fact = 1;
        
        // i.e.: 5! = 5 * 4 * 3 * 2 * 1 = 120.
        while (number > 0)
            fact *= number--;
        
        return fact;
    }
    
    private class factHelper {
        public void validateNumber(int num)
        {
            if (num < 0)
                // Cannot factorialize negative numbers. 
                throw new ArgumentException("Cannot factorialize negative numbers!");
            
            if (num > 12)
                // Number grows too big, int cannot hold.
                throw new OverflowException("Number is too big to factorialize!");
        }
    }
}
