using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TicTacToeFacade.Controller;
using TicTacToeFacade.Enums;
using TicTacToeFacade.Models;
using TicTacToeFacade.Presentation;
using TicTacToeFacade.ResultCheck;

namespace TicTacToeFacade.Facade
{
    internal class GameFacade
    {
        public static void Start()
        {
            Board board = new Board();
            Result result = new Result();
            Player player1 = new Player(MarkType.X);
            Player player2 = new Player(MarkType.O);

            GameManager.Initialize(player1, player2, board, result);

            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Game.StartGame(player1, player2);
        }
    }
}
