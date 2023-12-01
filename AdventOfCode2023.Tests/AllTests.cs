namespace AdventOfCode2023.Tests;

[TestClass]
public class Day1Tests
{
    [TestMethod]
    public void TestDay1()
    {
        var input = new[]
        {
            "+1",
            "-2",
            "+3",
            "+1"
        };

        var result = Day1.FindCalibrationValue(input);

        Assert.AreEqual(3, result);
    }
}