using System;
using System.Collections.Generic;
using System.Text;

namespace ChessConsoleIAMath.Model
{
    class ClassGame
    {
        public string NomeJogo,
            Versão,
            Jogador1, Jogador2,
            Mensagem,
            NotBranca, NotPreta,
            Origem, Destino,
            Peca,
            Cor,
            B1 = "-", B2 = "-", B3 = "-", B4 = "-", B5 = "-", B6 = "-", B7 = "-", B8 = "-", B9 = "-", B10 = "-",//Substituir por vetores 
            B11 = "-", B12 = "-", B13 = "-", B14 = "-", B15 = "-",
            P1 = "-", P2 = "-", P3 = "-", P4 = "-", P5 = "-", P6 = "-", P7 = "-", P8 = "-", P9 = "-", P10 = "-",//Substituir por vetores
            P11 = "-", P12 = "-", P13 = "-", P14 = "-", P15 = "-";

        public int Jogo,
            Turno,
            TurAnt;

        public void Cabecalho(string nomeJogo, string versao)
        {
            NomeJogo = nomeJogo;
            Versão = versao;
        }

        public void Introducao(string jogador1, string jogador2, int jogo)
        {
            Jogador1 = jogador1;
            Jogador2 = jogador2;
            Jogo = jogo;
        }

        public void Notacao(int turno, string branca, string preta)
        {
            TurAnt = turno;
            NotBranca = branca;
            NotPreta = preta;
        }

        public void Instrucoes(string mensagem, string input)
        {
            Mensagem = mensagem;
        }
    }
}
