using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataMachine;
internal static class Utilities
{
    public static int[] GenerateSortedIntArray() => new int[] { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 };
    public static int[] GenerateUnSortedIntArray() => new int[] { 3, 69, 4, 1, 420, 69420, 81, 1337, 71, 90, 99 };

    public static bool CompareIntArrays(int[] a, int[] b)
    {
        if (a.Length != b.Length) return false;

        var result = true;
        for(var i = 0; i < a.Length; ++i)
        {
            if (a[i] != b[i])
            {
                result = false; 
                break;
            };
        }

        return result;
    }

    public static BinaryNode<int> GenerateTree1()
    {
        return new BinaryNode<int>
        {
            Value = 20,
            Right = new BinaryNode<int>
            {
                Value = 50,
                Right = new BinaryNode<int>
                {
                    Value = 100
                },
                Left = new BinaryNode<int>
                {
                    Value = 30,
                    Right = new BinaryNode<int>
                    {
                        Value = 45
                    },
                    Left = new BinaryNode<int>
                    {
                        Value = 29
                    }
                }

            },
            Left = new BinaryNode<int>
            {
                Value = 10,
                Right = new BinaryNode<int>
                {
                    Value = 15
                },
                Left = new BinaryNode<int>
                {
                    Value = 5,
                    Right = new BinaryNode<int>
                    {
                        Value = 7
                    }
                }
            }
        };
    }

    public static BinaryNode<int> GenerateTree2()
    {
        return new BinaryNode<int>
        {
            Value = 20,
            Right = new BinaryNode<int>
            {
                Value = 50,
                Left = new BinaryNode<int>
                {
                    Value = 30,
                    Right = new BinaryNode<int>
                    {
                        Value = 45,
                        Right = new BinaryNode<int>
                        {
                            Value = 49
                        }
                    },
                    Left = new BinaryNode<int>
                    {
                        Value = 29,
                        Left = new BinaryNode<int>
                        {
                            Value = 21
                        }
                    }
                }
            },
            Left = new BinaryNode<int>
            {
                Value = 10,
                Right = new BinaryNode<int>
                {
                    Value = 15
                },
                Left = new BinaryNode<int>
                {
                    Value = 5,
                    Right = new BinaryNode<int>
                    {
                        Value = 7
                    }
                }
            }
        };
    }
}
