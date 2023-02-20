using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOGOSHUB.Xadrez.Tabuleiro
{
    class TabuleiroException : Exception
    {

        public TabuleiroException(string msg) : base(msg)
        {
        }
    }
}
