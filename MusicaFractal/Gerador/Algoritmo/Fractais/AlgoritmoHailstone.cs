using System;
using System.Collections.Generic;

namespace Gerador.Algoritmo.Fractais
{
    public class AlgoritmoHailstone : IAlgoritmo
    {
        private int numero;
        private int notas;

        public AlgoritmoHailstone(int numero, int notas)
        {
            this.numero = numero;
            this.notas = notas;
        }

        public AlgoritmoHailstone() : this(7, 17) { }

        public List<int> GerarValores()
        {
            var sequencia = new List<int>();
            var valor = numero;
            for (int i = 0; i < notas; i++)
            {
                sequencia.Add(valor);
                if (valor == 1)
                    valor = numero;
                else if ((valor & 0x1) == 0)
                    valor /= 2;
                else
                    valor = 3 * valor + 1;
            }
            return sequencia;
        }
    }
}
