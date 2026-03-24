using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerealizerPraticcel;

internal class Usuario
{
    public Usuario(string nomeDoUsuario)
    {
        NomeDoUsuario = nomeDoUsuario;
    }

    public string NomeDoUsuario { get;  }
}
