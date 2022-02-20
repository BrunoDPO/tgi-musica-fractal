using System;
using System.Collections.Generic;

namespace Gerador.Musica.Escalas
{
    /// <summary>
    /// Notas musicais presentes na escala sol maior
    /// </summary>
    public class EscalaSolMaior : Escala
    {
        public EscalaSolMaior(byte oitavaCentral, bool fixarOitava)
            : base(oitavaCentral, 4, fixarOitava)
        {
            Notas.Add(NotaMusical.Do);          // Dó
            Notas.Add(NotaMusical.Re);          // Ré
            Notas.Add(NotaMusical.Mi);          // Mi
            Notas.Add(NotaMusical.FaSustenido); // Fá#/Solb
            Notas.Add(NotaMusical.Sol);         // Sol
            Notas.Add(NotaMusical.La);          // Lá
            Notas.Add(NotaMusical.Si);          // Si
        }

        public EscalaSolMaior() : this(5, false) { }
    }
}
