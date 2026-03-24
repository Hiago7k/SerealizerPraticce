using SerealizerPraticcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerealizerPraticce;

internal class DadosDoUsuario
{
    public List<Usuario> ListaDeUsuarios { get; }
    public string? Nome { get;  }
    public int Idade { get;  }
    public string? Email { get;  }



    public void AdicionarUsuarioNaLista(Usuario usuario)
    {
        ListaDeUsuarios.Add(usuario);
    }
}


