namespace Biblioteca
{
    public abstract class ItemBiblioteca
    {
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public int QuantidadePaginas { get; set; }

        protected ItemBiblioteca(string autor, string titulo, 
            int anoPublicacao, int quantidadePaginas)
        {
            Autor = autor;
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
            QuantidadePaginas = quantidadePaginas;
        }
    }
}
