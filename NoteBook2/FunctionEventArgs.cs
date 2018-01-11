using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook2
{
    class FunctionEventArgs : EventArgs
    {
        public readonly int _choose;
        public FunctionEventArgs(int choose)
        {
            this._choose = choose;
        }
    }
}
