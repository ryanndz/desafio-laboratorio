public class autor
{
    public string? nome;
    public string? nacionalidade;

    public autor(string Nome,string Nacionalidade)
   {
      nome = Nome;
      nacionalidade = Nacionalidade;
   }

    public void MostrarInfo()
    {
        Console.WriteLine($"{nome} {nacionalidade}"); 
    }
    
}