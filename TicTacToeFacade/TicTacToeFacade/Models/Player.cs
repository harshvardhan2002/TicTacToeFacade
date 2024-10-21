using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeFacade.Enums;

namespace TicTacToeFacade.Models
{
    internal class Player
    {
        public MarkType Type { get; set; }

        public Player(MarkType mark)
        {
            Type = mark;
        }
        public void Play(Board board, int position)
        {
            if (board.GetCellMark(position) == MarkType.EMPTY)
            {
                board.SetCellMark(position, Type);
            }
        }
    }
}
