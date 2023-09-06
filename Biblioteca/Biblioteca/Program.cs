namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new();
            biblioteca.AdicionarItem(new Livro("Clean code", "Robert C. Martin", 2009, 425, new DateTime(2023, 09,06).Date));
            biblioteca.AdicionarItem(new MidiaDigital("Storytelling com Dados", "Cole Nussbaumer Knaflic", 2019, 319, new DateTime(2023, 09, 10).Date));
            biblioteca.AdicionarItem(new Revista("Revista Tecnologia e Sociedade", "Christian Luiz da Silva", 2023, 339, new DateTime(2023, 09, 01).Date));


            biblioteca.Emprestar(biblioteca.itens[0]);
            biblioteca.Devolver(biblioteca.itens[0]);
        }
    }
}
