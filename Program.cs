using SerealizerPraticce;
using SerealizerPraticcel;

Usuario hiago = new Usuario("Hiago");

Console.WriteLine($"Digite o Nome:");
string nomeDoUsuario = Console.ReadLine()!;
Console.WriteLine($"Digite a Idade: :");
int idadeDoUsuario = Convert.ToInt32(Console.ReadLine())!;
Console.WriteLine($"Digite o Email: :");
string emailDoUsuario = Console.ReadLine()!;

DadosDoUsuario dados = new DadosDoUsuario(nomeDoUsuario, idadeDoUsuario, emailDoUsuario);
dados.AdicionarUsuarioNaLista(hiago);

dados.GerarArquivoJson();