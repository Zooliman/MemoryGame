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
        private BoardCell [,] m_boardMatrix;
        private int m_boardRows = 0;
        private int m_boardColumns = 0;
        private int m_boardPairs = 0;
        

        public Board(int[] array)
        {
            this.m_boardRows = array[0];
            this.m_boardColumns = array[1];
            this.m_boardPairs = (this.m_boardRows * this.m_boardColumns) / 2;
            this.m_boardMatrix = new BoardCell [this.m_boardRows, this.m_boardColumns];
            initializeBoard();
        }

        public List<char> generateCards() // makes a list of the cards values to put in the board
        {
            char firstCharacter = 'Z';
            List<char> cardsList = new List<char>();
            for (int i = 0; i < this.m_boardPairs; i++)
            {
                cardsList.Add(firstCharacter); //to change it 
                cardsList.Add(firstCharacter--);
            }
            return cardsList;
        }
        // {Z,Z,Y,Y,X,X} 

        public void initializeBoard()
        {

            List<char> cardsList = generateCards();
            
            Random rand = new Random();
            int randomIndex = -1; 
            for (int i = 0; i < this.m_boardRows; i++)
            {
                for (int j = 0; j < this.m_boardColumns; j++)
                {
                    randomIndex = rand.Next(cardsList.Count());
                    this.m_boardMatrix[i, j] = new BoardCell(cardsList[randomIndex]); 
                    cardsList.RemoveAt(randomIndex);
                }
            }
        }

        public void setBoardCell(int row, int col)
        {
            m_boardMatrix[row, col].IsChecked = true;
        }

        public int[] getSize()
        {
            int[] size = {this.m_boardRows, this.m_boardColumns};
            return size;
        }

        public BoardCell[,] getBoard()
        {
            {
                return this.m_boardMatrix;
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
}
