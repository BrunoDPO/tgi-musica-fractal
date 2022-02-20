using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gerador.Musica.Escalas
{
    public class EscalaPersonalizada : Escala
    {
        public EscalaPersonalizada(List<NotaMusical> notas)
        {
            foreach(var nota in notas)
                this.Notas.Add(nota); 
        }
    }
}
