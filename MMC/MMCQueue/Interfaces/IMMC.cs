namespace MMCQueue.Interfaces;

public interface IMMC
{
    /// <summary>
    /// Probability of an empty system
    /// </summary>
    /// <param name="lam">Arrival rate</param>
    /// <param name="mu">Service rate</param>
    /// <param name="c">Number of servers</param>
    /// <returns></returns>
    double Pempty(double lam, double mu, int c);
    /// <summary>
    /// Utilization
    /// <param name="lam">Arrival rate</param>
    /// <param name="mu">Service rate</param>
    /// <param name="c">Number of servers</param>
    /// <returns>Returns the system utilization (rho)</returns>
    /// </summary>
    double Rho(double lamda, double mu, int c);
}
