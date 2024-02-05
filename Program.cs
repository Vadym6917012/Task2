namespace Task2
{
    class Program
    {
        static int N = 8;

        public static void Main(string[] args)
        {
            int[,] board = new int[N, N];

            board = FillArrayWithZeroos(board, N);

            Logic(board, 0);

            PrintArray(board, N);
        }

        public static bool Logic(int[,] board, int row)
        {
            if (row == N)
            {
                return true;
            }

            for (int i = 0; i < N; i++)
            {
                if (CheckFerzie(board, row, i))
                {
                    board[row, i] = 1;

                    if (Logic(board, row + 1))
                    {
                        return true;
                    }

                    board[row, i] = 0;
                }
            }

            return false;
        }

        public static bool CheckFerzie(int[,] board, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (board[i, col] == 1)
                {
                    return false;
                }
            }

            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            for (int i = row, j = col; i >= 0 && j < N; i--, j++)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            return true;
        }

        public static int[,] FillArrayWithZeroos(int[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = 0;
                }
            }

            return array;
        }

        public static void PrintArray(int[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}