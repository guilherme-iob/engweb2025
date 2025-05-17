public interface IIdioma 
{
    String AloMundo();
}

public class Portugues : IIdioma //entity framework
{
    public String AloMundo() 
    {
        return "Alo Mundo";
    }
}

public class Ingles : IIdioma //novo framework orm que faz muito mais e melhor
{
    public string AloMundo()
    {
        return "Hello World";
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        IIdioma idioma = new Ingles();

        //Console.WriteLine("1 para Ingles e 2 para Pt-br");
        //var qualIdioma = Console.ReadLine();

        //if (qualIdioma == "1")
        //{
        //    idioma = new Ingles();
        //}
        //else 
        //{
        //    idioma = new Portugues();
        //}


        Console.WriteLine(idioma.AloMundo());
    }
}