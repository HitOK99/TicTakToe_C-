/*
1) Я маю створити дошку з початковими значеннями

2) Потрібно реалізувати функцію для виводу дошки на екран

3) Додам змінну для визначення поточного гравця

4) Дозволю гравцям вводити свої ходи

5) Перевірю коректність введеного значення

6) Оновлю дошку після ходу гравця

7) Після кожного ходу очищу консоль і виведу оновлену дошку

8) Створю функцію для перевірки виграшної комбінації

9) Реалізую функцію для перевірки нічиєї

10) Додам завершення гри після виграшу або нічиєї
*/

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1;

    static void Main()
    {
        int choice;
        bool validInput;

        do
        {
            Console.Clear();
            DrawBoard();

            Console.WriteLine($"Гравець {currentPlayer}, введіть номер комірки:");

            validInput = int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O';

            if (validInput)
            {
                board[choice - 1] = (currentPlayer == 1) ? 'X' : 'O';

                if (CheckForWin())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine($"Переміг гравець {currentPlayer}!");
                    break;
                }

                if (CheckForDraw())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine("Нічия!");
                    break;
                }

                currentPlayer = (currentPlayer == 1) ? 2 : 1;
            }
            else
                Console.WriteLine("Некоректне введення. Спробуйте знову.");

        } while (true);
    }

    static void DrawBoard()
    {
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }

    static bool CheckForWin()
    {
        return (board[0] == board[1] && board[1] == board[2]) ||
            (board[3] == board[4] && board[4] == board[5]) ||
            (board[6] == board[7] && board[7] == board[8]) ||
            (board[0] == board[3] && board[3] == board[6]) ||
            (board[1] == board[4] && board[4] == board[7]) ||
            (board[2] == board[5] && board[5] == board[8]) ||
            (board[0] == board[4] && board[4] == board[8]) ||
            (board[2] == board[4] && board[4] == board[6]);
    }

    static bool CheckForDraw()
    {
        foreach (char cell in board)
        {
            if (cell != 'X' && cell != 'O')
                return false;
        }
        return true;
    }
}
