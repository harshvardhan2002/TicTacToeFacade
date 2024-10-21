using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeFacade.Enums;
using TicTacToeFacade.Exceptions;
using TicTacToeFacade.Models;
using TicTacToeFacade.ResultCheck;

namespace TicTacToeFacade.Controller
{
    internal class GameManager
    {
        static Board board;
        static Player currentPlayer;
        static Result result;
        public static void Initialize(Player player1, Player player2, Board newBoard, Result newResult)
        {
            board = newBoard;
            result = newResult;
            currentPlayer = player1;
        } 
        public static Player GetCurrentPlayer()
        {
            return currentPlayer;
        }
        public static void SwitchPlayer(Player player1, Player player2)
        {
            currentPlayer = currentPlayer == player1 ? player2 : player1;
        }
        public static bool TryMakeMove(int position)
        {
            if (position < 0 || position >= 9)
            {
                throw new SlotOutOfRangeException("Slot number must be between 1 and 9.");
            }
            else if (board.GetCellMark(position) != MarkType.EMPTY)
            {
                throw new SlotAlreadyFilledException("The selected slot is already filled, choose another slot.");
            }
            currentPlayer.Play(board, position);
            return true;
        }
        public static bool CheckForWinner()
        {
            return result.CheckAll(board);
        }
        public static bool IsBoardFull()
        {
            return board.IsBoardFull();
        }
        public static Board GetBoard()
        {
            return board;
        }
        
    }
}
