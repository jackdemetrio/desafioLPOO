Autor autor1 = new Autor("Colleen Hoover", "Americana");
autor1.MostrarInfo();

Livro livro1 = new Livro("O lado feio do amor", autor1);
livro1.MostrarInfo();

Livro livro2 = new Livro("É assim que acaba", autor1, 54.90);
livro2.MostrarInfo();

livro2.AplicarDesconto(10.00);
livro2.MostrarInfo();
livro2.AplicarDesconto(10);
livro2.MostrarInfo();
