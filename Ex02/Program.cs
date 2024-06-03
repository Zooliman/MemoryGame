using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
     class Program
    {
        public static void Main()
        {
            /* int[] a = { 6, 6 };
             int[] moveIndexes = new int[2];
             InputValidator inputValidator = new InputValidator();

             for (int i = 0; i < 10; i++)
             {
                 moveIndexes = inputValidator.getValidMove();
                 Console.WriteLine(moveIndexes[0] + "," + moveIndexes[1]);
             }*/

            InputValidator inputValidator = new InputValidator();
            int[] moveIndexes = new int[2];
            for (int i = 0; i < 10; i++)
            {
                moveIndexes = inputValidator.getValidBoardSize();
                Console.WriteLine(moveIndexes[0] + "," + moveIndexes[1]);
            }

            Console.ReadLine();

        }
    }
}
