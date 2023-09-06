namespace Biblioteca
{
    public class Biblioteca
    {
        public List<ItemBiblioteca> itens = new List<ItemBiblioteca>();

        public void AdicionarItem(ItemBiblioteca item)
        {
            itens.Add(item);
        }

        public void Emprestar(ItemBiblioteca item)
        {
            if (item is IPodeSerEMprestado itemEmprestimo)
            {
                itemEmprestimo.Emprestar();
            }
            else
            {
                Console.WriteLine("Item não disponível para empréstimo.");
            }
        }

        public void Devolver(ItemBiblioteca item)
        {
            if (item is IPodeSerEMprestado itemEmprestimo)
            {
                itemEmprestimo.Devolver();
            }
            else
            {
                Console.WriteLine("O item não é do tipo que pode ser devolvido.");
            }
        }
    }
}
