using System;

namespace Gerador.Musica
{
    /// <summary>
    /// Durações possíveis para as notas musicais, ordenadas de forma crescente.
    /// </summary>
    public enum Duracao : byte
    {
        Semifusa = 0,
        Fusa,
        Semicolcheia,
        Colcheia,
        Semínima,
        Mínima,
        Semibreve
    }
}
