namespace MMCKKQueue.Interfaces;

/// <summary>
/// Interface for M/M/c/K/K queueing model.
/// </summary>
public interface IMMCKK
{
    /// <summary>
    /// P0. Probability System is empty.
    /// </summary>
    /// <param name="lam">Arrival rate.</param>
    /// <param name="mu">Service rate.</param>
    /// <param name="c">Number of servers</param>
    /// <param name="K">Calling population</param>
    /// <returns>P0 ( probability of an empty system. )</returns>
    double Pempty(double lam, double mu, int c, int K);

    /// <summary>
    /// Mean number in the system.
    /// </summary>
    /// <param name="lam"> Arrival Rate </param>
    /// <param name="mu"> Service Rate </param>
    /// <param name="c"> Number of Servers </param>
    /// <param name="K"> Calling Population </param>
    /// <returns>L ( mean number in system. )</returns>
    double L(double lam, double mu, int c, int K);
}
