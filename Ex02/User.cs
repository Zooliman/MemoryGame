using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class User
    {
        private string m_UserName;

        public User(string i_UserName)
        {
            this.m_UserName = i_UserName;
        }

        public string UserName
        {
            get { return m_UserName; }
        } 
    }
}
