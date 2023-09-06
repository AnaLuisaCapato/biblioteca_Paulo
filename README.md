# Biblioteca_Paulo

Imagine um sistema de gerenciamento de uma biblioteca. Neste sistema, você deve usar classes abstratas e interfaces para modelar diferentes tipos de itens da biblioteca, como livros, revistas e mídias digitais (por exemplo, e-books).

Crie uma classe abstrata chamada "ItemBiblioteca" que contenha informações comuns a todos os itens, como título, autor, ano de publicação e número de páginas.

Defina uma interface chamada "PodeSerEmprestado" que declare métodos para empréstimo e devolução de itens.

Crie classes concretas para representar diferentes tipos de itens da biblioteca, como "Livro", "Revista" e "MidiaDigital". Essas classes devem herdar da classe abstrata "ItemBiblioteca" e implementar a interface "PodeSerEmprestado" se aplicável (você pode decidir que tipos de itens serão emprestáveis).

Implemente os métodos de empréstimo e devolução de acordo com a natureza do item. Por exemplo, um livro pode ser emprestado por um período definido, enquanto uma mídia digital pode ser emprestada indefinidamente.

Crie uma classe chamada "Biblioteca" que gerencie uma coleção de itens da biblioteca e forneça métodos para emprestar e devolver itens.

Crie instâncias de diferentes tipos de itens da biblioteca e demonstre como eles podem ser emprestados e devolvidos usando a classe "Biblioteca".
