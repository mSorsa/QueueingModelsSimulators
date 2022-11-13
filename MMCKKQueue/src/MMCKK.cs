namespace MMCKKQueue.src;

/// <summary>
/// M/M/c/K/K queueing model.
/// All formulas are found on page 261. See referenced material on git-page!
/// </summary>
public class MMCKK : IMMCKK
{
    IFactorializer factorializer;

    public MMCKK(Factorializer factorializer) { this.factorializer = factorializer; }


    /// <summary>
    /// P0. Probability System is empty.
    /// </summary>
    /// <param name="lam"> Arrival Rate </param>
    /// <param name="mu"> Service Rate </param>
    /// <param name="c"> Number of Servers </param>
    /// <param name="K"> Calling Population </param>
    /// <returns>P0 ( probability of empty system. )</returns>
    public double Pempty(double lam, double mu, int c, int K)
    {
        double sum = 0.0;

        for (int n = 0; n < c; n++)
            sum += factorializer.Factorial(K) / (factorializer.Factorial(n) * factorializer.Factorial(K - n)) * Math.Pow((lam / mu), n);

        for (int n = c; n <= K; n++)
            sum += (factorializer.Factorial(K) / (factorializer.Factorial(K - n) * factorializer.Factorial(c) * Math.Pow(c, n - c))) * Math.Pow((lam / mu), n);
        
        return Math.Round(Math.Pow(sum, -1), 3);
    }

    /// <summary>
    /// L is the mean number in the system.
    /// </summary>
    /// <param name="lam"> Arrival Rate </param>
    /// <param name="mu"> Service Rate </param>
    /// <param name="c"> Number of Servers </param>
    /// <param name="K"> Calling Population </param>
    /// <returns>L ( mean number in system. )</returns>
    public double L(double lam, double mu, int c, int K)
    {
        double sum = 0.0;
        
        for (int n = 0; n <= K; n++)
            sum += n * Pn(lam, mu, c, K, n);

        return Math.Round(Math.Pow(sum, -1), 3);
    }

    /// <summary>
    /// Pn, where n is the number in system.
    /// </summary>
    /// <param name="lam"> Arrival Rate </param>
    /// <param name="mu"> Service Rate </param>
    /// <param name="c"> Number of Servers </param>
    /// <param name="K"> Calling Population </param>
    /// <param name="n"> Given number in system </param>
    /// <returns>The probability of n number in system</returns>
    private double Pn(double lam, double mu, int c, int K, int n)
    {
        if (n < c)
        {
            return (factorializer.Factorial(K) / (factorializer.Factorial(n) * factorializer.Factorial(K - n)))
                    * Math.Pow((lam / mu), n)
                    * Pempty(lam, mu, c, K);
        }

        
        return factorializer.Factorial(K) / (factorializer.Factorial(K-n) * factorializer.Factorial(c) * Math.Pow(c, c-n))
                * Math.Pow((lam / mu), n)
                * Pempty(lam, mu, c, K);
    }
}
