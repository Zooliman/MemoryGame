using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class MemoryGame
    {
        private Board m_Board;
        private User m_User1;
        private User m_User2;
        private Computer m_Computer;
        private bool m_IsPlayingAgainstComputer;
        

        public MemoryGame() {
      
        }
        public void startGame()
        {
          initializeGameDetails();
            
    

        }

        private void initializeGameDetails()
        {
            string user1Name = InputValidator.getValidUserName();
            this.m_User1 = new User(user1Name);
            string user2Name;

            if (InputValidator.getOpponentType() == 1)
            {
                user2Name = InputValidator.getValidUserName();
                this.m_User2 = new User(user2Name);
                this.m_IsPlayingAgainstComputer = false;
            }
            else
            {
                this.m_Computer = new Computer();
                this.m_IsPlayingAgainstComputer = true;
            }

            int[] boardDimensions = InputValidator.getValidBoardSize();
            Board board = new Board(boardDimensions);



        }



    }
}
