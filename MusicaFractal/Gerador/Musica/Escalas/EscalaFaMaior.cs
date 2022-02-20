using System;
using System.Collections.Generic;

namespace Gerador.Musica.Escalas
{
    /// <summary>
    /// Notas musicais presentes na escala fá maior
    /// </summary>
    public class EscalaFaMaior : Escala
    {
        public EscalaFaMaior(byte oitavaCentral, bool fixarOitava)
            : base(oitavaCentral, 3, fixarOitava)
        {
            Notas.Add(NotaMusical.Do);  // Dó
            Notas.Add(NotaMusical.Re);  // Ré
            Notas.Add(NotaMusical.Mi);  // Mi
            Notas.Add(NotaMusical.Fa);  // Fá
            Notas.Add(NotaMusical.Sol); // Sol
            Notas.Add(NotaMusical.La);  // Lá
            Notas.Add(NotaMusical.Si);  // Si
        }

        public EscalaFaMaior() : this(5, false) { }
    }
}
