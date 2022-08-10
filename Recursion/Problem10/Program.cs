namespace Problem10
{
    internal class Program
    {
        /*
          You are given a matrix with passable and impassable cells. Write a
          recursive program that finds all paths between two cells in the matrix. 1
         */

        static char[,] lab =
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
        };

        static string[] path =
            new string[lab.GetLength(0) * lab.GetLength(1)];
        static int position = 0;

        static void Main(string[] args)
        {
            FindPath(0, 0, "T");
        }

        static void FindPath(int row, int col, string direction)
        {
            if (row < 0 || col < 0 || col >= lab.GetLength(1) || row >= lab.GetLength(0))
            {
                return;
            }

            path[position] = direction;
            position++;

            if (lab[row, col] == 'e')
            {
                Console.WriteLine("Exit Found!");
                PrintPath(path, 1, position - 1);
            }

            if (lab[row, col] == ' ')
            {
                lab[row, col] = 's';

                FindPath(row, col - 1, "L");
                FindPath(row, col + 1, "R");
                FindPath(row + 1, col, "D");
                FindPath(row - 1, col, "U");

                lab[row, col] = ' ';
            }

            position--;
        }

        static void PrintPath(string[] path, int startPos, int endPos)
        {
            Console.Write("Path Taken:");
            for (int i = startPos; i < endPos; i++)
            {
                Console.Write(path[i]);
            }
            Console.WriteLine();
        }
    }
}
