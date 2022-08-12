namespace Problem10
{
    internal class Program
    {
        /*
          You are given a matrix with passable and impassable cells. Write a
          recursive program that finds all paths between two cells in the matrix.
         */

        static char[,] lab =
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
        };

        static List<string> path =
            new List<string>();

        static void Main(string[] args)
        {
            FindPath(0, 0, " ");
        }

        static void FindPath(int row, int col, string direction)
        {
            if (row < 0 || col < 0 || col >= lab.GetLength(1) || row >= lab.GetLength(0))
            {
                return;
            }

            path.Add(direction);

            if (lab[row, col] == 'e')
            {
                Console.WriteLine("Exit Found!");

                Console.Write("Path Taken:");
                path.ForEach(x => Console.Write(x));

                Console.WriteLine();
            }
            else if (lab[row, col] == ' ')
            {
                lab[row, col] = 's';

                FindPath(row, col - 1, "L");
                FindPath(row, col + 1, "R");
                FindPath(row + 1, col, "D");
                FindPath(row - 1, col, "U");

                lab[row, col] = ' ';
            }

            path.RemoveAt(path.Count - 1);
        }
    }
}