namespace TicTacToe;

public class TicTacToeModel
{
    public char[] Board { get; private set; } = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public int CurrentPlayer { get; set; } = 1;

    public bool MakeMove(int choice)
    {
        if (choice < 1 || choice > 9 || Board[choice - 1] == 'X' || Board[choice - 1] == 'O')
            return false;

        Board[choice - 1] = (CurrentPlayer == 1) ? 'X' : 'O';
        return true;
    }

    public bool CheckForWin()
    {
        return (Board[0] == Board[1] && Board[1] == Board[2]) ||
               (Board[3] == Board[4] && Board[4] == Board[5]) ||
               (Board[6] == Board[7] && Board[7] == Board[8]) ||
               (Board[0] == Board[3] && Board[3] == Board[6]) ||
               (Board[1] == Board[4] && Board[4] == Board[7]) ||
               (Board[2] == Board[5] && Board[5] == Board[8]) ||
               (Board[0] == Board[4] && Board[4] == Board[8]) ||
               (Board[2] == Board[4] && Board[4] == Board[6]);
    }

    public bool CheckForDraw()
    {
        foreach (char cell in Board)
        {
            if (cell != 'X' && cell != 'O')
                return false;
        }
        return true;
    }
}