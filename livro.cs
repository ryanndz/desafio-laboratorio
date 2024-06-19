public class livro
{
    public string? titulo;
    public autor autor;
    public double preco;

    public livro(string Titulo, autor Autor)
   {
      titulo = Titulo;
      autor = Autor;
   }
   public livro(string Titulo, autor Autor, double Preco)
   {
      titulo = Titulo;
      autor = Autor;
      preco = Preco;
   }
   public void MostrarInfo()
    {
        Console.WriteLine($"{titulo} {autor.nome} {preco}"); 
    }
   public void aplicarDesconto(double Valor)
    {
        preco -= (preco*Valor/100);  
    }
    public void aplicarDesconto(int Valor)
    {
        preco = preco-Valor;
    }
}