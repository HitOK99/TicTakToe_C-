namespace TicTacToe;

public class TicTacToeController
{
    private readonly TicTacToeModel model;
    private readonly TicTacToeView view;

    public TicTacToeController(TicTacToeModel model, TicTacToeView view)
    {
        this.model = model;
        this.view = view;
    }

    public void PlayGame()
    {
        bool isGameRunning = true;

        while (isGameRunning)
        {
            view.DrawBoard(model.Board);

            int choice = view.GetPlayerInput(model.CurrentPlayer);

            if (!model.MakeMove(choice))
            {
                view.ShowMessage("Некоректне введення. Спробуйте знову.");
                continue;
            }

            if (model.CheckForWin())
            {
                view.DrawBoard(model.Board);
                view.ShowMessage($"Переміг гравець {model.CurrentPlayer}!");
                isGameRunning = false;
            }
            else if (model.CheckForDraw())
            {
                view.DrawBoard(model.Board);
                view.ShowMessage("Нічия!");
                isGameRunning = false;
            }
            else
            {
                model.CurrentPlayer = (model.CurrentPlayer == 1) ? 2 : 1;
            }
        }
    }
}