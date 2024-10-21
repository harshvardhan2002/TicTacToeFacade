﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFacade.Exceptions
{
    internal class SlotOutOfRangeException: Exception
    {
        public SlotOutOfRangeException(string message) : base(message) { }
    }
}