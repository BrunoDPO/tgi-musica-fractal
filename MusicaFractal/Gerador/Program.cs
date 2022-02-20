using System;
using System.Collections.Generic;

using Gerador.Algoritmo.Fractais;
using Gerador.Musica;
using Gerador.Musica.Escalas;
using Gerador.Musica.Midi;

namespace Gerador
{
    class Program
    {
        static void Main(string[] args)
        {
            var musicaFractal = new MusicaFractal(new AlgoritmoKoch(), new EscalaReMaior());
            var notas = musicaFractal.Construir(Duracao.Semínima, true);
            foreach (var n in notas)
                Console.WriteLine(n.ToString());
            var tocador = new TocadorMidi();
            tocador.Tocar(notas.ToArray(), 120);
            Console.WriteLine("Pressione qualquer tecla para continuar . . .");
            Console.ReadKey();
        }
    }
}
