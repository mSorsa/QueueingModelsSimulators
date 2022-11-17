using System.Diagnostics;

namespace MMCKKTester;

public class MMCKKTests
{
    IMMCKK MMCKK = new MMCKK(new MathHelper.src.Factorializer());
    
    [Theory]
    [InlineData(1.0, 1.0, 1.0, 10, 0)]
    [InlineData(0.025, 0.1, 2, 10, 0.065)]
    [InlineData(9, 0.1, 1, 5, 0)]
    [InlineData(10, 7, 3, 4, 0.028)]
    [InlineData(0.5, 1.0, 3, 5, 0.129)]
    public void MMCKKPempty_Valid(double lam, double mu, int c, int K, double expected)
    {
        double actual = MMCKK.Pempty(lam, mu, c, K);

        Assert.Equal(expected, actual);
    }


    [Theory]
    [InlineData(0.025, 0.1, 4, 10, 3, 0.1987)]  //Valid
    [InlineData(0.025, 0.1, 6, 10, 1, 0.2675)]  //Valid
    [InlineData(0.3, 0.2, 3, 5, 2, 0.2025)]     //Valid
    [InlineData(0.025, 0.1, 3, 10, 5, 0.0536)]  //Valid
    [InlineData(0.8, 0.5, 2, 7, 5, 0.0000)]     //Valid
    [InlineData(0.4, 0.3, 2, 7, 6, 0.0000)]     //Valid
    [InlineData(5, 4, 2, 7, 2, 0.0328)]         //Valid
    public void MMCKKPn_Valid(double lam, double mu, int c, int K, int n, double expected)
    {
        // Method we are testing
        double actual = Math.Round(MMCKK.Pn(lam, mu, c, K, n), 4);

        // Assert results are what we expect
        Assert.Equal(expected, actual);
    }


    [Theory]
    [InlineData(0.025, 0.1, 2, 10, 3.166)]
    [InlineData(0.75, 0.8, 5, 7, 3.426)]
    [InlineData(10, 7, 3, 4, 2.416)]
    [InlineData(9, 0.1, 1, 5, 4.989)]
    public void MMCKKL_Valid(double lam, double mu, int c, int K, double expected)
    {
        double actual = MMCKK.L(lam, mu, c, K);

        Assert.Equal(expected, actual);
    }
}