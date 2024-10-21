using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeFacade.Enums;

namespace TicTacToeFacade.Models
{
    internal class Board
    {
        private List<Cell> cells;
        public Board()
        {
            cells = new List<Cell>(new Cell[9]);
            for (int i = 0; i < 9; i++)
            {
                cells[i] = new Cell();
            }
        }
        public bool IsBoardFull()
        {
            return cells.All(cell => !cell.IsEmpty());
        }
        public void SetCellMark(int position, MarkType mark)
        {
            cells[position].SetMark(mark);
        }
        public MarkType GetCellMark(int position)
        {
            return cells[position].GetMark();
        }
    }
}
