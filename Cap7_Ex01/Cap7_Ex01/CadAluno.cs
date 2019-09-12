using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7_Ex01
{
    class SalaAula
    {
        public string SALA;
    }

    class CadAluno : SalaAula
    {
        public string NOME;
        public float[] NOTA = new float[4];

        public float CalcMedia()
        {
            byte i;
            float SOMA, MEDIA;
            SOMA = 0;
            for (i = 0; i <= 3; i++)
            {
                SOMA = SOMA + NOTA[i];
            }
            MEDIA = SOMA / 4;
            return MEDIA;
        }
    }
}
