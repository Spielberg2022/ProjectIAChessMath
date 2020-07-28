using System;

using ChessConsoleIAMath.Controller;

namespace ChessConsoleIAMath
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassGameController gameController = new ClassGameController();

            gameController.PlayGame();
        }        
    }
}
