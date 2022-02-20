using System;
using System.Collections.Generic;

namespace Gerador.Musica
{
    /// <summary>
    /// Representação de uma escala com suas notas musicais
    /// </summary>
    public abstract class Escala
    {
        public byte OitavaCentral { get; private set; }

        public bool FixarOitava { get; private set; }

        public int Deslocamento { get; private set; }

        public List<NotaMusical> Notas { get; private set; }

        public Escala() : this(5, false) { }

        public Escala(byte oitavaCentral) : this(oitavaCentral, 0, false) { }

        public Escala(byte oitavaCentral, bool fixarOitava) : this(oitavaCentral, 0, fixarOitava) { }

        public Escala(byte oitavaCentral, int deslocamento, bool fixarOitava)
        {
            if (oitavaCentral < 0 || oitavaCentral > 11)
                throw new ArgumentException(
                    string.Format("O valor {0} é inválido para o parâmetro no construtor da escala.", oitavaCentral),
                    "oitavaCentral");
            this.OitavaCentral = oitavaCentral;
            this.FixarOitava = fixarOitava;
            this.Deslocamento = deslocamento;
            Notas = new List<NotaMusical>(7);
        }

        public virtual NotaMusical ConverterValor(int valor)
        {
            int posicao = valor + Deslocamento;
            int totalNotas = Notas.Count;
            byte oitava = this.OitavaCentral;

            if (!this.FixarOitava)
            {
                posicao += this.Notas.Count * OitavaCentral;
                totalNotas *= 10;
                oitava = (byte)((posicao / this.Notas.Count) % 10);
            }

            // Trata valores negativos
            while (posicao < 0)
                posicao += totalNotas;

            posicao %= this.Notas.Count;

            // Ajusta a oitava caso seja fixa e possua deslocamento
            if (this.FixarOitava && Deslocamento > posicao)
                oitava++;

            var nota = (NotaMusical)this.Notas[posicao].Clone();
            nota.Oitava = oitava;
            return nota;
        }
    }
}
