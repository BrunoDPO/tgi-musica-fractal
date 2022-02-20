using System;
using System.Collections.Generic;

namespace Gerador.Algoritmo
{
    /// <summary>
    /// Interface para a execução dos algoritmos de geração dos fractais
    /// </summary>
    public interface IAlgoritmo
    {
        List<int> GerarValores();
    }
}
