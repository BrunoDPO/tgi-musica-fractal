using System;
using System.Collections.Generic;

namespace Gerador.Musica.Escalas
{
    /// <summary>
    /// Notas musicais presentes na escala si maior
    /// </summary>
    public class EscalaSiMaior : Escala
    {
        public EscalaSiMaior(byte oitavaCentral, bool fixarOitava)
            : base(oitavaCentral, 6, fixarOitava)
        {
            Notas.Add(NotaMusical.DoSustenido);     // Dó#/Reb
            Notas.Add(NotaMusical.ReSustenido);     // Ré#/Mib
            Notas.Add(NotaMusical.Mi);              // Mi
            Notas.Add(NotaMusical.FaSustenido);     // Fá#/Solb
            Notas.Add(NotaMusical.SolSustenido);    // Sol#/Láb
            Notas.Add(NotaMusical.LaSustenido);     // Lá#/Sib
            Notas.Add(NotaMusical.Si);              // Si
        }

        public EscalaSiMaior() : this(5, false) { }
    }
}
