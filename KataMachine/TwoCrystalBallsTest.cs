using Core.TwoCrystalBalls;

namespace KataMachine;
public class TwoCrystalBallsTest
{
    [Fact]
    public void DoTwoCrystalBalls()
    {
        var random = new Random();
        var index = random.Next(100, 10_000 ) * 10_000;
        var arraySize = index + 10_000;
        var array = new bool[arraySize];
        var i = 0;

        while (i < arraySize)
        {
            if (i >=  index) array[i] = true;
            else array[i] = false;
        }

        Assert.Equal(TwoCrystalBalls.MaxHeight(array), index);
        Assert.Equal(TwoCrystalBalls.MaxHeight(new bool[] { false, false, false, false }), index - 1);
    }
}
