using Core;

namespace KataMachine;
internal static class Utilities
{
    public static int[] GenerateSortedIntArray() => new int[] { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 };
    public static int[] GenerateUnSortedIntArray() => new int[] { 3, 69, 4, 1, 420, 69420, 81, 1337, 71, 90, 99 };

    public static bool CompareIntArrays(IEnumerable<int> left, IEnumerable<int> right)
    {
        var a = left.ToArray();
        var b = right.ToArray();
        if (a.Length != b.Length) return false;

        var result = true;
        for (var i = 0; i < a.Length; ++i)
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

    public static List<List<WeightedNode>> GenerateWeightedList()
    {
        var weightedNodeList = new List<List<WeightedNode>>();
        weightedNodeList.Add(new List<WeightedNode> {
            new WeightedNode {
                To = 1, Weight = 3
            },
            new WeightedNode {
                To = 2, Weight = 1
            }
        });

        weightedNodeList.Add(new List<WeightedNode>
        {
            new WeightedNode { To = 0, Weight = 3},
            new WeightedNode { To = 2, Weight = 4},
            new WeightedNode { To = 4, Weight = 1}
        });

        weightedNodeList.Add(new List<WeightedNode>{
            new WeightedNode {To = 1, Weight =4 },
            new WeightedNode {To = 3, Weight =7 },
            new WeightedNode {To = 0, Weight =1 },
        });

        weightedNodeList.Add(new List<WeightedNode> {
           new WeightedNode {To =2, Weight =7 },
           new WeightedNode {To =4, Weight =5 },
           new WeightedNode {To =6, Weight =1 },
        });

        weightedNodeList.Add(new List<WeightedNode> {
            new WeightedNode {To = 1, Weight =1 },
            new WeightedNode {To = 3, Weight =5 },
            new WeightedNode {To = 5, Weight =2 },
        });

        weightedNodeList.Add(new List<WeightedNode> {
            new WeightedNode {To = 6, Weight =1 },
            new WeightedNode {To = 4, Weight =2 },
            new WeightedNode {To = 2, Weight =18 },
        });

        weightedNodeList.Add(new List<WeightedNode> {
            new WeightedNode {To = 3, Weight =1 },
            new WeightedNode {To = 5, Weight =1 },
        });

        return weightedNodeList;
    }

    public static List<List<WeightedNode>> GenerateWeightedList2()
    {
        var weightedNodeList = new List<List<WeightedNode>>();
        weightedNodeList.Add(new List<WeightedNode> {
            new WeightedNode {To = 1 Weight = 3},
            new WeightedNode {To = 2, Weight =1 },
            });

        weightedNodeList.Add(new List<WeightedNode> {
            new WeightedNode {To = 4, Weight = 1}
        });

        weightedNodeList.Add(new List<WeightedNode> {
            new WeightedNode {To = 3, Weight = 7}
        });

        weightedNodeList.Add(new List<WeightedNode>());

        weightedNodeList.Add(new List<WeightedNode>{
                new WeightedNode {To = 1, Weight =1 },
                new WeightedNode {To = 3, Weight =5 },
                new WeightedNode {To = 5, Weight =2 },
                });

        weightedNodeList.Add(new List<WeightedNode>{
                new WeightedNode {To = 6, Weight = 18},
                new WeightedNode {To = 6, Weight =1 },

                });
        weightedNodeList.Add(new List<WeightedNode>{
                new WeightedNode {To = 3, Weight =1 },
                });

        return weightedNodeList;
    }

    public static List<List<int>> GenerateWeightedMatrix()
    {
        var matrix = new List<List<int>>();
        matrix.Add(new List<int> { 0, 3, 1, 0, 0, 0, 0 });
        matrix.Add(new List<int> { 0, 0, 0, 0, 1, 0, 0 });
        matrix.Add(new List<int> { 0, 0, 7, 0, 0, 0, 0 });
        matrix.Add(new List<int> { 0, 0, 0, 0, 0, 0, 0 });
        matrix.Add(new List<int> { 0, 1, 0, 5, 0, 2, 0 });
        matrix.Add(new List<int> { 0, 0, 18, 0, 0, 0, 1 });
        matrix.Add(new List<int> { 0, 0, 0, 1, 0, 0, 1 });

        return matrix;
    }
}
