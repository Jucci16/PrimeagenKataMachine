using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BubbleSort;
public static class BubbleSort
{
    public static int[] Sort(int[] numbers)
    {
        for (var i = 0; i < numbers.Length; ++i)
        {
            for (var j = i + 1; j < numbers.Length; ++j)
            {
                var a = numbers[i];
                var b = numbers[j];

                if (b < a)
                {
                    var temp = a;
                    numbers[i] = numbers[j]; 
                    numbers[j] = temp;
                }
            }
        }

        return numbers;
    }
}
