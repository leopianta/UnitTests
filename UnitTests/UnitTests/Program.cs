using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using UnitTests;

internal class Program
{
    public static List<Contato> ContatosList = new List<Contato>();

    private static void Main(string[] args)
    {
        Menu();
    }

    private static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Cadastro de contatos");
        Console.WriteLine();
        Console.WriteLine("Opções:");
        Console.WriteLine("1- Listar");
        Console.WriteLine("2- Cadastrar");
        Console.WriteLine("3- Excluir");
        Console.WriteLine("");        

        var opt = Console.ReadLine();

        switch (opt)
        {
            case "1":
                ListarContatos();
                break;
            case "2":
                CadastrarContato();
                break;
            case "3":
                ExcluirContato();
                break;
            default:
                Menu();
                break;
        }

        Menu();
    }

    private static void ListarContatos()
    {
        Console.WriteLine("Contatos cadastrados:");
        Console.WriteLine();

        foreach (var c in ContatosList)
        {
            Console.WriteLine($"Nome: {c.nome}");
            Console.WriteLine($"Idade: {c.idade}");
            Console.WriteLine($"Cpf: {c.cpf}");
            Console.WriteLine();
        }
        Console.WriteLine("4- Menu inicial");

        var opt = Console.ReadLine();
        if (opt.Equals("4"))
        {
            Menu();
        }

    }

    private static void CadastrarContato()
    {
        var contato = new Contato();

        Console.WriteLine("Digite o nome:");
        contato.nome = Console.ReadLine();
        Console.WriteLine("Digite a idade:");
        contato.idade = Console.ReadLine();
        Console.WriteLine("Digite o cpf:");
        contato.cpf = Console.ReadLine();
        Console.WriteLine();

        ContatosList.Add(contato);
    }

    private static void ExcluirContato()
    {
        Console.WriteLine("Digite o nome a ser excluído:");
        var nome = Console.ReadLine().ToLower();

        var contato = ContatosList.FirstOrDefault(x => x.nome.ToLower().Equals(nome));
        ContatosList.Remove(contato);

        Menu();
    }
}