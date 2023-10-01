using Core.MazeSolver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataMachine;
public class MazeSolverTests
{
    [Fact]
    public void SolveMaze()
    {
        var maze = new string[]
        {
            "xxxxxxxxxx x",
            "x        x x",
            "x        x x",
            "x xxxxxxxx x",
            "x          x",
            "x xxxxxxxxxx"
        };

        var answer = new Point[]
        {
            new Point(10, 0),
            new Point(10, 1),
            new Point(10, 2),
            new Point(10, 3),
            new Point(10, 4),
            new Point(9, 4),
            new Point(8, 4),
            new Point(7, 4),
            new Point(6, 4),
            new Point(5, 4),
            new Point(4, 4),
            new Point(3, 4),
            new Point(2, 4),
            new Point(1, 4),
            new Point(1, 5),
        };

        var result = MazeSolver.Solve(maze, 'x', new Point(10, 0), new Point(1, 5)).ToList();
        Assert.Equal(answer.Length, result.Count);

        for (var i = 0; i < answer.Length; ++i)
        {
            var pos1 = answer[i];
            var pos2 = result[i];

            Assert.Equal(pos1, pos2);
        }
    }
}
