using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.TwoCrystalBalls;
public static class TwoCrystalBalls
{
    public static int MaxHeight(bool[] levels)
    {
        var stepDistance = (int)Math.Floor(Math.Sqrt(levels.Length));
        var level = 0;

        while(level < levels.Length)
        {
            if (levels[level])
            {
                level -= stepDistance;
                break;
            }

            level += stepDistance;
        }

        if (level > levels.Length) level -= stepDistance;
        for (var i = level; i < levels.Length; ++i)
        {
            if (levels[i]) return i;
        }

        return -1;
    }
}
