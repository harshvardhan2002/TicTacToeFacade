using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeFacade.Enums;
using TicTacToeFacade.Models;

namespace TicTacToeFacade.ResultCheck
{
    internal class Result
    {
        public bool CheckFirstRow(Board board)
        {
            if (board.GetCellMark(0) == board.GetCellMark(1) && board.GetCellMark(1) == board.GetCellMark(2) && board.GetCellMark(0) != MarkType.EMPTY)
            {
                return true;
            }
            return false;
        }
        public bool CheckSecondRow(Board board)
        {
            if (board.GetCellMark(3) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(5) && board.GetCellMark(3) != MarkType.EMPTY)
            {
                return true;
            }
            return false;
        }
        public bool CheckThirdRow(Board board)
        {
            if (board.GetCellMark(6) == board.GetCellMark(7) && board.GetCellMark(7) == board.GetCellMark(8) && board.GetCellMark(6) != MarkType.EMPTY)
            {
                return true;
            }
            return false;
        }
        public bool CheckFirstColumn(Board board)
        {
            if (board.GetCellMark(0) == board.GetCellMark(3) && board.GetCellMark(3) == board.GetCellMark(6) && board.GetCellMark(0) != MarkType.EMPTY)
            {
                return true;
            }
            return false;
        }
        public bool CheckSecondColumn(Board board)
        {
            if (board.GetCellMark(1) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(7) && board.GetCellMark(1) != MarkType.EMPTY)
            {
                return true;
            }
            return false;
        }
        public bool CheckThirdColumn(Board board)
        {
            if (board.GetCellMark(2) == board.GetCellMark(5) && board.GetCellMark(5) == board.GetCellMark(8) && board.GetCellMark(2) != MarkType.EMPTY)
            {
                return true;
            }
            return false;
        }
        public bool CheckLeftDiagonal(Board board)
        {
            if (board.GetCellMark(0) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(8) && board.GetCellMark(0) != MarkType.EMPTY)
            {
                return true;
            }
            return false;
        }
        public bool CheckRightDiagonal(Board board)
        {
            if (board.GetCellMark(2) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(6) && board.GetCellMark(2) != MarkType.EMPTY)
            {
                return true;
            }
            return false;
        }
        public bool CheckAll(Board board)
        {
            if (CheckFirstRow(board) || CheckSecondRow(board) || CheckThirdRow(board) ||
                CheckFirstColumn(board) || CheckSecondColumn(board) || CheckThirdColumn(board) ||
                CheckLeftDiagonal(board) || CheckRightDiagonal(board))
            {
                return true;
            }
            return false;
        }
    }
}
