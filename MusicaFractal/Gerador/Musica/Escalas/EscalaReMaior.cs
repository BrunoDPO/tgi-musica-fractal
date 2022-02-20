using System;
using System.Collections.Generic;

namespace Gerador.Musica.Escalas
{
    /// <summary>
    /// Notas musicais presentes na escala ré maior
    /// </summary>
    public class EscalaReMaior : Escala
    {
        public EscalaReMaior(byte oitavaCentral, bool fixarOitava)
            : base(oitavaCentral, 1, fixarOitava)
        {
            Notas.Add(NotaMusical.DoSustenido); // Dó#/Reb
            Notas.Add(NotaMusical.Re);          // Ré
            Notas.Add(NotaMusical.Mi);          // Mi
            Notas.Add(NotaMusical.FaSustenido); // Fá#/Solb
            Notas.Add(NotaMusical.Sol);         // Sol
            Notas.Add(NotaMusical.La);          // Lá
            Notas.Add(NotaMusical.Si);          // Si
        }

        public EscalaReMaior() : this(5, false) { }
    }
}
