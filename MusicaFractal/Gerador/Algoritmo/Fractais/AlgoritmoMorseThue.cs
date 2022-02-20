using System;
using System.Collections.Generic;

namespace Gerador.Algoritmo.Fractais
{
    public class AlgoritmoMorseThue : IAlgoritmo
    {
        private long inicio;
        private int multiplicador;
        private short baseNumerica;
        private int quantidade;

        public AlgoritmoMorseThue(long inicio, int multiplicador, short baseNumerica, int quantidade)
        {
            this.inicio = inicio;
            this.multiplicador = multiplicador;
            this.baseNumerica = baseNumerica;
            this.quantidade = quantidade;
        }

        public AlgoritmoMorseThue() : this(0, 1, 2, 30) { }

        public List<int> GerarValores()
        {
            List<int> sequencia = new List<int>();
            for (int i = 0; i < quantidade; i++, inicio++)
            {
                long valor = inicio * multiplicador;
                List<short> valorConvertido = ConverterBase(valor, baseNumerica);
                int somaDigitosValorConvertido = 0;
                foreach (var v in valorConvertido)
                    somaDigitosValorConvertido += v;
                sequencia.Add(somaDigitosValorConvertido);
            }
            return sequencia;
        }

        private static List<short> ConverterBase(long valor, short baseNumerica)
        {
            List<short> resultado = new List<short>();

            for (int i = 0; valor > 0; i++)
            {
                resultado.Insert(0, (short)(valor % baseNumerica));
                valor /= baseNumerica;
            }
            return resultado;
        }
    }
}
