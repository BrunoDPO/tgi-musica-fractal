using System;
using System.Collections.Generic;

namespace Gerador.Algoritmo.Fractais
{
    public class AlgoritmoKoch : IAlgoritmo
    {
        private int direcaoInicial;
        private int fatorDirecao;
        private int iteracoes;
        
        public AlgoritmoKoch(int direcaoInicial, int fatorDirecao, int iteracoes)
        {
            this.direcaoInicial = direcaoInicial;
            this.fatorDirecao = fatorDirecao;
            this.iteracoes = iteracoes;
        }

        public AlgoritmoKoch() : this(0, 1, 3) { }

        public List<int> GerarValores()
        {
            var lista = new List<int>();
            Curva(ref lista, direcaoInicial, fatorDirecao, iteracoes);
            return lista;
        }

        private int Curva(ref List<int> valores, int direcao, int fator, int iteracoes)
        {
            if (iteracoes > 0)
            {
                Curva(ref valores, direcao, fator, iteracoes - 1);
                Curva(ref valores, direcao + fator, fator, iteracoes - 1);
                Curva(ref valores, direcao - fator, fator, iteracoes - 1);
                Curva(ref valores, direcao, fator, iteracoes - 1);
            }
            valores.Add(direcao);
            return direcao;
        }
    }
}
