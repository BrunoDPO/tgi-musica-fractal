using System;
using System.Collections.Generic;

using Gerador.Algoritmo;
using Gerador.Musica;

namespace Gerador
{
    /// <summary>
    /// Coordena a criação da música fractal
    /// </summary>
    public class MusicaFractal
    {
        private IAlgoritmo algoritmo;
        private Escala escala;

        public MusicaFractal(IAlgoritmo algoritmo, Escala escala)
        {
            this.algoritmo = algoritmo;
            this.escala = escala;
        }

        public List<NotaMusical> Construir(Duracao duracaoMinima, bool variarDuracao)
        {
            var valores = algoritmo.GerarValores();
            var notas = new List<NotaMusical>();

            for(int i = 0; i < valores.Count; i++)
            {
                var nota = escala.ConverterValor(valores[i]);
                nota.Duracao = duracaoMinima;

                var anterior = notas.Count - 1;
                if (variarDuracao && anterior > -1 &&
                    notas[anterior].Igual(nota, false, true) &&
                    notas[anterior].Duracao < Duracao.Semibreve)
                    notas[anterior].Duracao++;
                else
                    notas.Add(nota);
            }

            return notas;
        }
    }
}
