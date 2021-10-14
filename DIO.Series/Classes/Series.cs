namespace DIO.Series
{
  public class Serie : EntidadeBase 
  { //Atributos

    private Genero Genero {get; set; }

    private string Titulo {get; set; }

    private string Descrição {get; set; }

    private int Ano {get; set; }

    private bool Excluido { get; set; }

    // Metádos

    public Serie(int id, Genero genero, string titulo, string descricao, int ano, int ano)
    {
      this.Id = id;
      this.Genero = genero;
      this.Titulo = titulo;
      this.Descricao = descricao;
      this.Ano = ano;
      this.Excluido = false;

    }

      public override string ToString() 
      {// Environment.NewLine https://docs.microsofit.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1

      string retorno = " ";
      retorno += "Gênero: " + this.Genero + Environment.NewLine;
      retorno += "Titulo: " + this.Titulo + Environment.NewLine;
      retorno += "Descricao: " + this.Descricao + Environment.NewLine;
      retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
      retorno += "Excluido: " + this.Excluido + Environment.NewLine;
      return retorno;

    }
      public string retornaTitulo()
      {
        return this.Titulo;
      }

      internal int retornaId()
      {
        return this.Id;
      }

      internal bool retornaExcluido()
      {
        return this.Excluido;
      }


      public void Excluir()
      {
        this.Excluido = true;
      }
  }

}
