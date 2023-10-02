using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.QuickSort;
public static class QuickSort
{
    public static int[] Sort(int[] numbers)
    {
        return SortArray(numbers, 0, numbers.Length - 1);
    }

    public static int[] SortArray(int[] numbers, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex) return numbers;

        var pivotIndex = Partition(numbers, minIndex, maxIndex);
        SortArray(numbers, minIndex, pivotIndex - 1);
        SortArray(numbers, pivotIndex + 1, maxIndex);

        return numbers;
    }

    public static int Partition(int[] numbers, int min, int max)
    {
        var pivot = numbers[max];
        var index = min - 1;

        for (var i = min; i < max; ++i)
        {
            if (numbers[i] <= pivot)
            {
                index++;
                Swap(numbers, index, i);
            }
        }

        index++;
        Swap(numbers, index, max);

        return index;
    }

    public static void Swap(int[] numbers, int indexA, int indexB)
    {
        var temp = numbers[indexA]; 
        numbers[indexA] = numbers[indexB];
        numbers[indexB] = temp;
    }
}
