using System.Text;

namespace Biblioteca
{
    public class Livro : ItemBiblioteca, IPodeSerEMprestado
    {
        public DateTime DataEmprestimo { get; set; }
        public int Prazo = 10;

        public Livro(string autor, string titulo, int anoPublicacao, 
            int quantidadePaginas, DateTime dataEmprestimo) 
            : base(autor, titulo, anoPublicacao, quantidadePaginas)
        {
            DataEmprestimo = dataEmprestimo.Date;
        }

        public void Emprestar()
        {

            StringBuilder builder = new();
            builder.AppendLine("--- EMPRÉSTIMO: ---");
            builder.AppendLine($"DATA DO EMPRÉSTIMO: {DataEmprestimo.Date}");
            builder.AppendLine($"DATA DA DEVOLUÇÃO: {DataEmprestimo.Date.AddDays(Prazo)}" + Environment.NewLine);
            builder.AppendLine($"--- INFORMAÇÕES DO ITEM: ---");
            builder.AppendLine($"TÍTULO: {Titulo}");
            builder.AppendLine($"AUTOR: {Autor}");
            builder.AppendLine($"ANO DA PUBLICAÇÃO: {AnoPublicacao}");
            builder.AppendLine($"QUANTIDADE DE PÁGINAS: {QuantidadePaginas}");
            
            Console.WriteLine(builder.ToString());           
        }

        public void Devolver()
        {
            Console.WriteLine("--- DEVOLUÇÃO: ---");
            Console.Write("Data de devolução: ");
            DateTime dataDevolucao = DateTime.Parse(Console.ReadLine());

            if (dataDevolucao > DataEmprestimo.Date.AddDays(Prazo))
            {
                Console.WriteLine($"O livro: {Titulo}, está atrasado!");
            }
            else
            {
                Console.WriteLine($"O livro: {Titulo}, está dentro do prazo.");
            }
        }

    }
}
