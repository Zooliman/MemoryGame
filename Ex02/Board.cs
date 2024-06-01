using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Board
    {
        private int [,] m_boardMatrix;
        private int m_boardRows = 0;
        private int m_boardColumns = 0;
        private int m_boardPairs = 0;

        public Board(int[] array)
        {
            this.m_boardRows = array[0];
            this.m_boardColumns = array[1];
            this.m_boardPairs = (this.m_boardRows * this.m_boardColumns) / 2;
            this.m_boardMatrix = new int[this.m_boardRows, this.m_boardColumns];

        }

        /*public void printBoard()
        {
            StringBuilder columnsTextLine = new StringBuilder("  ");
            StringBuilder rowsText = new StringBuilder("   ");

            int currentLetter = 65;
            for (int i = 0; i < 6; i++)
            {
                columnsTextLine.AppendFormat("  {0}", (char)currentLetter++);
            }
            columnsTextLine.AppendLine();

            string dividerLine = "=====";
            for (int i = 0; i < 4; i++)
            {
                rowsText.AppendFormat("=====");
            }
            rowsText.AppendFormat("{0}" ,string.CopyTo(1, dividerLine.ToCharArray(), dividerLine.Length, m_boardColumns));


            Console.WriteLine(columnsTextLine.ToString());
             
        }
        */

    }
}
