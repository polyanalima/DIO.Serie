using System;

namespace DIO.Series
{
    class Program
    {
      static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario =  ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
              switch(opcaoUsuario)
              {
                case "1":
                    ListaSeries();
                    break;
                case "2":
                    InserirSerie();
                    break;
                case "3";
                    AtualizarSerie();
                    break;
                case "4":
                    ExcluirSerie();
                    break;
                case "5":
                    VisualizarSerie();
                    break;
                case "C":
                    Console.Clear();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
              }

              opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.WriteLine();
        }

      private void ListaSeries()
      {
        Console.WriteLine("Listar Series");

        var lista = repositorio.Lista();

        if(lista.Count == 0)
        {
          Console.WhriteLine("Nenhuma série encontrada.");
          return;
        }
        foreach (var serie in lista)
        { 
          var excluido = serie.retornaExcluido();


          Console.WhriteLine("#ID {0}: - {1} - {2}", serie.RetornaId(),serie.RetornaTitulo(), (excluido ? "Excluido" : "");
        }
      }

      private void InserirSerie()  
      {
        Console.WriteLine("Inserir série.");

        //https:docs.microsoft.com/pt-br/dotnet/api/system/enum.getvalues?view=netcore-3.1
        //https:docs.microsoft.com/pt-br/dotnet/api/system/enum.getname?view=netcore-3.1
        foreach (int i in Enum.GetValues(typeof(Genero)));
        {
          Console.WriteLine("{0}-{1}", i , Enum.GetName(typeof(Genero), i));
        }

          Console.Write("Digite o gênero entre as opções acima: ");
          int entradaGenero= int.Parse(Console.ReadLine());

          Console.Write("Digite o Título da Série: ");
          int entradaTitulo= int.Parse(Console.ReadLine());

          Console.Write("Digite o Ano de Inicio da Série: ");
          int entradaAno= int.Parse(Console.ReadLine());

          Console.Write("Digite a Descrição da Série: ");
          int entradaDescricao= int.Parse(Console.ReadLine());

          Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                      genero: (Genero)entradaGenero,
                                      titulo: entradaTitulo,
                                      ano: entradaAno,
                                      descricao: entradaDescricao);
      }
    private static void VisualizarSerie()
   {
	    Console.WriteLine("Digite o id da série: ");
	    indiceSerie = int.Parse(Console.ReadLine());

      var serie = repositorio.RetornaPorId(indiceSerie);

      Console.WriteLine(serie);

}

    public static void AtualizarSerie()
    {
      Console.Write("Digite o Id da Série: ");
      int indiceSerie = int.Parse(Console.ReadLine());

      //https:docs.microsoft.com/pt-br/dotnet/api/system/enum.getvalues?view=netcore-3.1
      //https:docs.microsoft.com/pt-br/dotnet/api/system/enum.getname?view=netcore-3.1

      foreach( int i in Enum.GetValues(typeof(Genero)));
      {
        Console.WriteLine("{0}-{1}" , i , Enum.GetName(typeof(Genero), i));
      }
      Console.Write("Digite o gênero entre as opções acima: ");
          int entradaGenero= int.Parse(Console.ReadLine());

          Console.Write("Digite o Título da Série: ");
          int entradaTitulo= int.Parse(Console.ReadLine());

          Console.Write("Digite o Ano de Inicio da Série: ");
          int entradaAno= int.Parse(Console.ReadLine());

          Console.Write("Digite a Descrição da Série: ");
          int entradaDescricao= int.Parse(Console.ReadLine());

          Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                      genero: (Genero)entradaGenero,
                                      titulo: entradaTitulo,
                                      ano: entradaAno,
                                      descricao: entradaDescricao);
      }

    }
    public static void ExcluirSerie()
    {
      Console.Write("Digite o Id da Série: ");
      int indiceSerie = int.Parse(Console.ReadLine());

      repositorio.Exclui(indiceSerie);

    }
    public static string ObterOpcaoUsuario()
    {
      Console.WriteLine();
      Console.WriteLine("DIO Séries a seu dispor!!!");
      Console.WriteLine("Informe a opcao desejada: ");

      Console.WriteLine("1- Listar séries");
      Console.WriteLine("2- Inserir nova série");
      Console.WriteLine("3- Atualizar série");
      Console.WriteLine("4- Excluir série");
      Console.WriteLine("5- Visualizar série");
      Console.WriteLine("6- Limpar tela");
      Console.WriteLine("X  Sair");
      Console.WriteLine();

      string opcaoUsuario = Console.ReadLine().ToUpper();
      Console.WriteLine();
      return opcaoUsuario;


    }
    }
}
