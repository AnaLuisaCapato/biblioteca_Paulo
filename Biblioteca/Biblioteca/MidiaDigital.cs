using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MidiaDigital : ItemBiblioteca, IPodeSerEMprestado
    {
        public DateTime DataEmprestimo { get; set; }
        public MidiaDigital(string autor, string titulo, int anoPublicacao, 
            int quantidadePaginas, DateTime dataEmprestimo) 
            : base(autor, titulo, anoPublicacao, quantidadePaginas)
        {
            DataEmprestimo = dataEmprestimo;
        }

        public void Emprestar()
        {

            StringBuilder builder = new();
            builder.AppendLine("--- EMPRÉSTIMO: ---");
            builder.AppendLine($"DATA DO EMPRÉSTIMO: {DataEmprestimo.Date}");
            builder.AppendLine($"DATA DA DEVOLUÇÃO: Sem prazo para devolução para MÍDIA DIGITAL." + Environment.NewLine);
            builder.AppendLine($"--- INFORMAÇÕES DO ITEM: ---");
            builder.AppendLine($"TÍTULO: {Titulo}");
            builder.AppendLine($"AUTOR: {Autor}");
            builder.AppendLine($"ANO DA PUBLICAÇÃO: {AnoPublicacao}");
            builder.AppendLine($"QUANTIDADE DE PÁGINAS: {QuantidadePaginas}");

            Console.WriteLine(builder.ToString());
        }

        public void Devolver()
        {
            Console.WriteLine("Mídia digital devolvida");
        }
    }
}
