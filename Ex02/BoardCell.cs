using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class BoardCell
    {
        private char m_CellValue;
        private bool m_IsChecked;

        public BoardCell(char i_CellValue)
        {
            this.m_CellValue = i_CellValue;
            this.m_IsChecked = false;
        }

        public char CellValue{
            get { return m_CellValue; }
            set { m_CellValue = value; }
        }

        public bool IsChecked
        {
            get { return m_IsChecked; }
            set { m_IsChecked = value; }
        }

    }

}
