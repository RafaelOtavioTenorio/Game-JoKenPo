using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo
{
    class Game
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }
        public static Image[] images =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Papel.png"),
            Image.FromFile("imagens/Tesoura.png"),
            Image.FromFile("imagens/Ganhar.png"),
            Image.FromFile("imagens/Perder.png"),
            Image.FromFile("imagens/Empatar.png"),

        };

        public Image ImgPC { get; private set; }
        public Image ImgJogador { get; private set; }

        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPC();

            ImgJogador = images[jogador];
            ImgPC= images[pc];

            if (jogador == pc)
            {
                return Resultado.Empatar;
            } else if ( (jogador == 0 && pc == 2) || (jogador == 1 && pc == 0) || (jogador == 2 && pc == 1) )
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }

            
        }

        private int JogadaPC()
        {
            int mil = DateTime.Now.Millisecond;

            if (mil <= 333)
            {
                return 0;
            } else if (mil > 333 && mil <= 666)
            {
                return 1;
            } else
            {
                return 2;
            }           
        }

    }
}
