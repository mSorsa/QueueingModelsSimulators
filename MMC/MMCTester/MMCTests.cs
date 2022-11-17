namespace MMCTester;

public class MMCTests
{
    IMMC MMCQueue = new MMC(new MathHelper.src.Factorializer());

    [Theory]
    [InlineData(0.5, 1.0, 1, 0.5)]
    [InlineData(1.5, 2.0, 1, 0.75)]
    [InlineData(5.0, 4.0, 5, 0.25)]
    [InlineData(9.0, 5.0, 2, 0.9)]
    [InlineData(0.2, 0.25, 1, 0.8)]
    public void MMCrho_Valid(double lam, double mu, int c, double expected)
    {
        // Act
        double actual = MMCQueue.Rho(lam, mu, c);

        // Assert
        Assert.Equal(expected, actual);
    }

    //[Theory]
    //[InlineData(0.5, 1.0, 1, 0.5)]
    //[InlineData(1.5, 2.0, 1, 0.4)]
    //[InlineData(5.0, 4.0, 5, 0.286)]
    //[InlineData(9.0, 5.0, 2, 0.053)]
    //[InlineData(0.2, 0.25, 1, 0.2)]
    //public void MMCPempty_Valid(double lam, double mu, int c, double expected)
    //{
    //    double actual = MMCQueue.Pempty(lam, mu, c);

    //    Assert.Equal(expected, actual);
    //}

}
    