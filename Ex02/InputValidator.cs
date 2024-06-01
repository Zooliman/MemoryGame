using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class InputValidator
    {

        public static string getValidUserName()
        {
            return "";
        }

        public static int getOpponentType()
        {
            return 0;
        }
        
        /*
         * To check if theres a better way to implement this
         * 
         */
        public static int [] getValidBoardSize()
        {
            int[] board = new int[2];
            int numberOfRows = 0;
            int numberOfCols = 0;
            bool isValidNum = false;
            while (numberOfRows < 4 || numberOfRows > 6)
            {
                Console.WriteLine("Enter a valid number of rows (between 4 to 6): ");
                isValidNum = int.TryParse(Console.ReadLine(), out board[0]);
                numberOfRows = board[0];
            }
            while (numberOfCols< 4 || numberOfCols > 6)
            {
                Console.WriteLine("Enter a valid number of cols (between 4 to 6): ");
                isValidNum = int.TryParse(Console.ReadLine(), out board[1]);
                numberOfCols = board[1];

                if (numberOfRows * numberOfCols % 2 != 0)
                {
                    numberOfCols = -1;
                }
                
            }
            return board;

        }
    }
}
