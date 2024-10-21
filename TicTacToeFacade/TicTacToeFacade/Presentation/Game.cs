using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeFacade.Controller;
using TicTacToeFacade.Enums;
using TicTacToeFacade.Exceptions;
using TicTacToeFacade.Models;
using TicTacToeFacade.ResultCheck;

namespace TicTacToeFacade.Presentation
{
    internal class Game
    {
        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < 9; i += 3)
            {
                Console.WriteLine($"{FormatCell(board.GetCellMark(i))} | {FormatCell(board.GetCellMark(i + 1))} | {FormatCell(board.GetCellMark(i + 2))}");
                if (i < 6)
                {
                    Console.WriteLine("--+---+--");
                }
            }
        }
        private static string FormatCell(MarkType mark)
        {
            return mark == MarkType.EMPTY ? " " : mark.ToString();
        }
        public static void StartGame(Player player1, Player player2)
        {
            bool gameOngoing = true;

            while (gameOngoing)
            {
                PrintBoard(GameManager.GetBoard());
                Console.WriteLine($"\n{GameManager.GetCurrentPlayer().Type}'s turn. Pick a slot (1-9):");

                int position = GetValidPosition();
                gameOngoing = HandlePlayerMove(player1, player2, position - 1);

            }
        }
        private static bool HandlePlayerMove(Player player1, Player player2, int position)
        {
            try
            {
                GameManager.TryMakeMove(position);

                if (GameManager.CheckForWinner())
                {
                    PrintBoard(GameManager.GetBoard());
                    Console.WriteLine($"{GameManager.GetCurrentPlayer().Type} wins!");
                    return false; 
                }
                else if (GameManager.IsBoardFull())
                {
                    PrintBoard(GameManager.GetBoard());
                    Console.WriteLine("the game ends in a draw!");
                    return false; 
                }

                GameManager.SwitchPlayer(player1, player2);
                return true;
            }
            catch (SlotOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return true; 
            }
            catch (SlotAlreadyFilledException ex)
            {
                Console.WriteLine(ex.Message);
                return true;
            }
        }

        private static int GetValidPosition()
        {
            int position = 0;
            bool validInput = false;

            while (!validInput)
            {
                string input = Console.ReadLine();

                try
                {
                    position = Convert.ToInt32(input);

                    if (position >= 1 && position <= 9)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
                    }
                    
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
                }
            }

            return position;
        }
    }
}
