using MMCKKQueue.Interfaces;
using MMCKKQueue.src;

namespace MMCKKTester;

public class MMCKKTests
{
    IMMCKK MMCKK = new MMCKK();
    
    [Theory]
    [InlineData(1.0, 1.0, 1.0, 10, 0)]
    [InlineData(0.025, 0.1, 2, 10, 0.065)]
    [InlineData(9, 0.1, 1, 5, 0)]
    [InlineData(10, 7, 3, 4, 0.028)]
    [InlineData(0.5, 1.0, 3, 5, 0.129)]
    public void MMCKKPempty_Valid(double lam, double mu, int c, int K, double trueValue)
    {
        double p0 = MMCKK.Pempty(lam, mu, c, K);

        Assert.Equal(p0, trueValue);
    }

    [Theory]
    [InlineData(0.025, 0.1, 2, 10, 3.166)]
    [InlineData(0.75, 0.8, 5, 7, 3.426)]
    [InlineData(10, 7, 3, 4, 2.416)]
    [InlineData(9, 0.1, 1, 5, 4.989)]
    public void MMCKKL_Valid(double lam, double mu, int c, int K, double trueValue)
    {
        double L = MMCKK.L(lam, mu, c, K);

        Assert.Equal(trueValue, L);
    }
}