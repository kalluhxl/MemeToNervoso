 class Program
{
    static void Main()
    {
        Console.Write("Usuário, o que você pensa sobre mim? ");
        string texto = Console.ReadLine();

        Console.WriteLine("\n- E sabe o que eu penso de você?");
        Console.WriteLine(texto.Substring(0, Math.Min(10, texto.Length)) + "... NÃO, PERA.");
        Console.WriteLine("Tô nervoso");
    }
}
