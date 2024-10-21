using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFacade.Exceptions
{
    internal class SlotAlreadyFilledException:Exception
    {
        public SlotAlreadyFilledException(string message) : base(message) { }
    }
}
