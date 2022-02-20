using System;

namespace Gerador.Musica
{
    /// <summary>
    /// Representação de uma nota musical
    /// </summary>
    public class NotaMusical : ICloneable
    {
        private Duracao duracao;
        public Duracao Duracao
        {
            get { return duracao; }
            set
            {
                if (!Enum.IsDefined(typeof(Duracao), value))
                    throw new ArgumentException(
                        string.Format("O valor {0} é inválido para a propriedade da nota musical.", value), "Duracao");
                duracao = value;
            }
        }

        private byte oitava;
        public byte Oitava
        {
            get { return oitava; }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException(
                        string.Format("O valor {0} é inválido para a propriedade da nota musical.", value), "Oitava");
                oitava = value;
            }
        }

        public byte Nota { get; private set; }

        public NotaMusical(byte nota) : this(5, nota, Duracao.Semibreve) { }

        public NotaMusical(byte oitava, byte nota) : this(oitava, nota, Duracao.Semibreve) { }

        public NotaMusical(byte oitava, byte nota, Duracao duracao)
        {
            this.Nota = nota;
            this.Oitava = oitava;
            this.Duracao = duracao;
        }

        public static NotaMusical FromMIDI(byte valor)
        {
            return new NotaMusical((byte)(valor / 12), (byte)(valor % 12));
        }

        public byte ToMIDI()
        {
            return (byte)(Nota + 12 * Oitava);
        }

        public bool Igual(NotaMusical b, bool ignorarOitava, bool ignorarDuracao)
        {
            return this.Nota == b.Nota &&
                (ignorarOitava || this.Oitava == b.Oitava) &&
                (ignorarDuracao || this.Duracao == b.Duracao);
        }

        public override string ToString()
        {
            return string.Concat(Oitava, "-", GetNota(Nota), "-", Duracao.ToString());
        }

        private static string GetNota(byte nota)
        {
            if (nota == 0)
                return "C";
            if (nota == 1)
                return "C#";
            if (nota == 2)
                return "D";
            if (nota == 3)
                return "D#";
            if (nota == 4)
                return "E";
            if (nota == 5)
                return "F";
            if (nota == 6)
                return "F#";
            if (nota == 7)
                return "G";
            if (nota == 8)
                return "G#";
            if (nota == 9)
                return "A";
            if (nota == 10)
                return "A#";
            return "B";
        }

        public object Clone()
        {
            return new NotaMusical(this.Oitava, this.Nota, this.Duracao);
        }

        public static readonly NotaMusical Do = new NotaMusical(0);
        public static readonly NotaMusical DoSustenido = new NotaMusical(1);
        public static readonly NotaMusical ReBemol = DoSustenido;
        public static readonly NotaMusical Re = new NotaMusical(2);
        public static readonly NotaMusical ReSustenido = new NotaMusical(3);
        public static readonly NotaMusical MiBemol = ReSustenido;
        public static readonly NotaMusical Mi = new NotaMusical(4);
        public static readonly NotaMusical Fa = new NotaMusical(5);
        public static readonly NotaMusical FaSustenido = new NotaMusical(6);
        public static readonly NotaMusical SolBemol = FaSustenido;
        public static readonly NotaMusical Sol = new NotaMusical(7);
        public static readonly NotaMusical SolSustenido = new NotaMusical(8);
        public static readonly NotaMusical LaBemol = SolSustenido;
        public static readonly NotaMusical La = new NotaMusical(9);
        public static readonly NotaMusical LaSustenido = new NotaMusical(10);
        public static readonly NotaMusical SiBemol = LaSustenido;
        public static readonly NotaMusical Si = new NotaMusical(11);
    }
}
