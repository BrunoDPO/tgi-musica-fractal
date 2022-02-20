using System;
using System.Collections.Generic;

namespace Gerador.Musica.Escalas
{
    /// <summary>
    /// Notas musicais presentes na escala mi maior
    /// </summary>
    public class EscalaMiMaior : Escala
    {
        public EscalaMiMaior(byte oitavaCentral, bool fixarOitava)
            : base(oitavaCentral, 2, fixarOitava)
        {
            Notas.Add(NotaMusical.DoSustenido);     // Dó#/Réb
            Notas.Add(NotaMusical.ReSustenido);     // Ré#/Mib
            Notas.Add(NotaMusical.Mi);              // Mi
            Notas.Add(NotaMusical.FaSustenido);     // Fá#/Solb
            Notas.Add(NotaMusical.SolSustenido);    // Sol#/Láb
            Notas.Add(NotaMusical.La);              // Lá
            Notas.Add(NotaMusical.Si);              // Si
        }

        public EscalaMiMaior() : this(5, false) { }
    }
}
