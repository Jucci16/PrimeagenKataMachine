using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BinarySearch;
public static class BinarySearch
{
    public static bool Search(int[] haystack, int needle)
    {
        var min = 0;
        var max = haystack.Length;

        while (min < max)
        {
            var pivot = CalculatePivot(min, max);
            var value = haystack[pivot];
            if (needle == value) return true;

            if (needle > value)
                min = pivot + 1;
            else
                max = pivot;
        }

        return false;
    }

    private static int CalculatePivot(int min, int max)
    {
        return (max - min) / 2 + min;
    }

}
