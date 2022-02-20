using System;
using System.Collections.Generic;

namespace Gerador.Musica.Escalas
{
    /// <summary>
    /// Notas musicais presentes na escala dó maior
    /// </summary>
    public class EscalaDoMaior : Escala
    {
        public EscalaDoMaior(byte oitavaCentral, bool fixarOitava)
            : base(oitavaCentral, 0, fixarOitava)
        {
            Notas.Add(NotaMusical.Do);  // Dó
            Notas.Add(NotaMusical.Re);  // Ré
            Notas.Add(NotaMusical.Mi);  // Mi
            Notas.Add(NotaMusical.Fa);  // Fá
            Notas.Add(NotaMusical.Sol); // Sol
            Notas.Add(NotaMusical.La);  // Lá
            Notas.Add(NotaMusical.Si);  // Si
        }

        public EscalaDoMaior() : this(5, false) { }
    }
}
