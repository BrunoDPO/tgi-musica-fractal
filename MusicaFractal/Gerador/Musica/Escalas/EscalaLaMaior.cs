using System;
using System.Collections.Generic;

namespace Gerador.Musica.Escalas
{
    /// <summary>
    /// Notas musicais presentes na escala lá maior
    /// </summary>
    public class EscalaLaMaior : Escala
    {
        public EscalaLaMaior(byte oitavaCentral, bool fixarOitava)
            : base(oitavaCentral, 5, fixarOitava)
        {
            Notas.Add(NotaMusical.DoSustenido);     // Dó#/Reb
            Notas.Add(NotaMusical.Re);              // Ré
            Notas.Add(NotaMusical.Mi);              // Mi
            Notas.Add(NotaMusical.FaSustenido);     // Fá#/Solb
            Notas.Add(NotaMusical.SolSustenido);    // Sol#/La
            Notas.Add(NotaMusical.La);              // Lá
            Notas.Add(NotaMusical.Si);              // Si
        }

        public EscalaLaMaior() : this(5, false) { }
    }
}
