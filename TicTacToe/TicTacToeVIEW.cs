using System;

namespace TicTacToe;

public class TicTacToeView
{
    public void DrawBoard(char[] board)
    {
        Console.Clear();
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public int GetPlayerInput(int currentPlayer)
    {
        Console.WriteLine($"Гравець {currentPlayer}, введіть номер комірки:");
        if (int.TryParse(Console.ReadLine(), out int choice))
            return choice;

        return -1;
    }
}