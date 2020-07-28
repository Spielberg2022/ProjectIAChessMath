using System;
using System.Collections.Generic;
using System.Text;

namespace ChessConsoleIAMath.View
{
    class ClassTelaInicial
    {
        public string NomeJogo,
            Versão,
            Jogador1, Jogador2,
            Mensagem,
            NotBranca, NotPreta,
            Origem, Destino,
            Peca,
            Cor,
            B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, B11, B12, B13, B14, B15, 
            P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15;

        public int Jogo,
            Turno,
            TurAnt;

        public override string ToString()
        {
            return "    " + NomeJogo + " --- Versão: " + Versão + "\n"
                + "\n╔═════════════════════════════════════════════════════════════════════════╗\n"
                + "║   Jogadores:   BRANCAS: " + Jogador1 + "\n"
                + "║                PRETAS: " + Jogador2 + "\n"
                + "║   Jogo nº: " + Jogo + "\n"
                + "╠═════════════════════════════════════════════════════════════════════════╣\n"
                + "║   TURNO: " + Turno + "\n"
                + "║   COR: " + Cor + " \n"
                + "║    ORIGEM: " + Origem + "\n"
                + "║    DESTINO: " + Destino + "\n"
                + "╠═══════════════════════════╬═════════════════════════════════════════════╣\n"
                + "║    ╔═════════════════╗    ║     PEÇAS BRANCAS CAPTURADAS:\n"
                + "║  8 ║ t c b d r b c t ║    ║\n"
                + "║  7 ║ p p p p p p p p ║    ║    " + B1 + " " + B2 + " " + B3 + " " + B4 + " " + B5 + " " + B6 + " " + B7 + " " + B8 + " " + B9 + " " + B10 + " " + B11 + " " + B12 + " " + B13 + " " + B14 + " " + B15 + "\n"
                + "║  6 ║ - - - - - - - - ║    ║\n"
                + "║  5 ║ - - - - - - - - ║    ║\n"
                + "║  4 ║ - - - - - - - - ║    ╬═════════════════════════════════════════════╣\n"
                + "║  3 ║ - - - - - - - - ║    ║     PEÇAS PRETAS CAPTURADAS: \n"
                + "║  2 ║ P P P P P P P P ║    ║\n"
                + "║  1 ║ T C B D R B C T ║    ║    " + P1 + " " + P2 + " " + P3 + " " + P4 + " " + P5 + " " + P6 + " " + P7 + " " + P8 + " " + P9 + " " + P10 + " " + P11 + " " + P12 + " " + P13 + " " + P14 + " " + P15 + "\n"
                + "║    ╚═════════════════╝    ║\n"
                + "║      a b c d e f g h      ║\n"
                + "╠═══════════════════════════╩═══════════════════════╩═════════════════════╣\n"
                + "║   Notação do turno: " + TurAnt + "." + NotBranca + "," + NotPreta + "\n"
                + "╠═════════════════════════════════════════════════════════════════════════╣\n"
                + "   >>> INSTRUÇÕES: " + Mensagem + "\n"
                + "╚═════════════════════════════════════════════════════════════════════════╝\n";
        }
    }
}
