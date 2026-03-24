using SerealizerPraticcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SerealizerPraticce;

internal class DadosDoUsuario
{
    public DadosDoUsuario(string? nome, int idade, string? email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }

    public List<Usuario> ListaDeUsuarios { get; }
    public string? Nome { get;  }
    public int Idade { get;  }
    public string? Email { get;  }



    public void AdicionarUsuarioNaLista(Usuario usuario)
    {
        ListaDeUsuarios.Add(usuario);
    }


    public void GerarArquivoJson() 
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            usuario = ListaDeUsuarios
        });
    }
}


