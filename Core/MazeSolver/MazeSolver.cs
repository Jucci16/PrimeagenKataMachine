using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MazeSolver;
public static class MazeSolver
{


    public static IEnumerable<Point> Solve(string[] maze, char wall, Point start, Point end)
    {
        return Walk(maze, wall, start, end, new HashSet<Point> { start }, new List<Point> { start });
    }

    private static Point GetUp(Point point) => new Point(point.X, point.Y - 1);
    private static Point GetRight(Point point) => new Point(point.X + 1, point.Y);
    private static Point GetDown(Point point) => new Point(point.X, point.Y + 1);
    private static Point GetLeft(Point point) => new Point(point.X - 1, point.Y);

    private static List<Point> Walk(string[] maze, char wall, Point currentPosition, Point end, HashSet<Point> visited, List<Point> path)
    {
        if (currentPosition == end) return path;

        var directions = new List<Point> { GetUp(currentPosition), GetRight(currentPosition), GetDown(currentPosition), GetLeft(currentPosition) };
        for (var i = 0; i < directions.Count; ++i)
        {

            currentPosition = directions[i];
            if (visited.Contains(currentPosition)) continue;
            if (IsWall(maze, wall, currentPosition)) continue;
            
            visited.Add(currentPosition);
            path.Add(currentPosition);
            Walk(maze, wall, currentPosition, end, visited, path);
            if (path[path.Count - 1] == end) break;

            path.Remove(currentPosition);
        }

        return path;
    }

    private static bool IsWall(string[] maze, char wall, Point point)
    {
        if (point.X < 0 || point.Y < 0) return true;
        if (point.Y > maze.Length || point.X > maze[point.Y].Length) return true;

        return maze[point.Y][point.X] == wall;
    }
}
