using System;
using System.Collections.Generic;
using System.Text;

using ChessConsoleIAMath.View;
using ChessConsoleIAMath.Model;

namespace ChessConsoleIAMath.Controller
{
    class ClassGameController
    {
        public ClassGame Game = new ClassGame();
        public ClassTelaInicial TelaInicial = new ClassTelaInicial();

        public void PlayGame()
        {
            Game.NomeJogo = "JOGO DE XADREZ";
            Game.Versão = "1.0";

            Game.Mensagem = "Digite o nome do jogador das peças Brancas...";
            SetTabuleiro(Game);
            Console.WriteLine(TelaInicial);
            Console.SetCursorPosition(26, 3);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Game.Jogador1 = Console.ReadLine();
            TelaInicial.Jogador1 = Game.Jogador1;
            Console.ResetColor();

            Console.Clear();

            Game.Mensagem = "Digite o nome do jogador das peças Pretas...";
            SetTabuleiro(Game);
            Console.WriteLine(TelaInicial);
            Console.SetCursorPosition(25, 4);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Game.Jogador2 = Console.ReadLine();
            TelaInicial.Jogador2 = Game.Jogador2;
            Console.ResetColor();

            ///Fim
            Console.Clear();
            Game.Mensagem = ">>> PARTIDA FINALIZADA <<<";
            SetTabuleiro(Game);
            Console.WriteLine(TelaInicial);
            Console.SetCursorPosition(0, 28);
            Console.ReadLine();
        }

        public void SetTabuleiro(ClassGame game)
        {
            TelaInicial.NomeJogo = game.NomeJogo;
            TelaInicial.Versão = game.Versão;
            TelaInicial.Mensagem = game.Mensagem;
        }
    }
}
