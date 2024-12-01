using TicTacToe;

namespace TicTacToe;
class Program
{
    static void Main()
    {
        var model = new TicTacToeModel();
        var view = new TicTacToeView();
        var controller = new TicTacToeController(model, view);

        controller.PlayGame();
    }
}