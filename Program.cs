autor a1 = new autor("ryan", "brasileiro");
a1.MostrarInfo();

livro joao_pe_de_feijao = new livro("joao do pe de feijao", a1, 100);
joao_pe_de_feijao.MostrarInfo();
joao_pe_de_feijao.aplicarDesconto(10.00);
joao_pe_de_feijao.MostrarInfo();
joao_pe_de_feijao.aplicarDesconto(10);
joao_pe_de_feijao.MostrarInfo();