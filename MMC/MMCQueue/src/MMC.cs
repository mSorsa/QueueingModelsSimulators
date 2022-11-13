using MathHelper.Interfaces;
using MathHelper.src;
using MMCQueue.Interfaces;

namespace MMCQueue.src;

public class MMC : IMMC
{
    IFactorializer factorializer = new Factorializer();
    
    /// <summary>
    /// Not working yet.
    /// </summary>
    /// <param name="lam"></param>
    /// <param name="mu"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public double Pempty(double lam, double mu, int c)
    {
        double sum = 0.0;
        double rho = Rho(lam, mu, c);

        for (int i = 0; i < c; i++)
        {
            sum += Math.Pow(c * rho, i) / factorializer.Factorial(i);
        }

        sum += Math.Pow(c * rho, c) * (1 / factorializer.Factorial(c)) * (1 / (1 - rho));

        sum = Math.Pow(sum, -1);
        
        return Math.Round(sum, 3);
    }

    /// <summary>
    /// Calculate rho.
    /// </summary>
    /// <param name="lamda" Arrival rate> Arrival Rate </param>
    /// <param name="mu" Service rate> Service Rate </param>
    /// <param name="c" Number of servers> Number of Servers </param>
    /// <returns></returns>
    public double Rho(double lamda, double mu, int c)
        => lamda / (c * mu);
    
    
}
