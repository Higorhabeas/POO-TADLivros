/*Exercício de modelagem TAD Livro
Disciplina POO
Professor: Fabio
Alunos: Felipe Fernandes de Bellis Ruas
        Higor Antônio da Silva*/

internal class Program
{
    private static void Main(string[] args)
    {
        /*criando 6 livros usando os métodos setLivro usando o método EscreverLivro
        Completo e o método QualEstiloLiterario*/
        Livro livro1 = new Livro();
        livro1.setLivro("Dom Casmurro", "Machado de Assis", "Romance", 1899);
        Console.WriteLine(livro1.EscreverLivroCompleto(livro1));  // Saída: 
        Console.WriteLine(livro1.QualEstiloLiterario(livro1.ano));

        Livro livro2 = new Livro();
        livro2.setLivro("O Universo numa casca de Noz", "Stephen Hawking", "Física", 2001);
        Console.WriteLine(livro2.EscreverLivroCompleto(livro2));
        Console.WriteLine(livro2.QualEstiloLiterario(livro2.ano));

        Livro livro3 = new Livro();
        livro3.setLivro("Cem Anos de Solidão", "Gabriel Garcia Matos", "Romance", 1967);
        Console.WriteLine(livro3.EscreverLivroCompleto(livro3));
        Console.WriteLine(livro3.QualEstiloLiterario(livro3.ano));

        Livro livro4 = new Livro();
        livro4.setLivro("Ariana, a Mulher", "Vinicius de Morais", "Poesia", 1936);
        Console.WriteLine(livro4.EscreverLivroCompleto(livro4));
        Console.WriteLine(livro4.QualEstiloLiterario(livro4.ano));

        Livro livro5 = new Livro();
        livro5.setLivro("Prosopopeia", "Bento Teixeira", "Poema", 1601);
        Console.WriteLine(livro5.EscreverLivroCompleto(livro5));
        Console.WriteLine(livro5.QualEstiloLiterario(livro5.ano));

        Livro livro6 = new Livro();
        livro6.setLivro("O guia do mochileiro das galáxias", "Douglas Adams", "Ficção", 1981);
        Console.WriteLine(livro6.EscreverLivroCompleto(livro6));
        Console.WriteLine(livro6.QualEstiloLiterario(livro6.ano));

        /*criando uma lista de livros conforme os que foram criados para 
        posterios ordenação por ano de publicação*/
        List<Livro> livros = new List<Livro>() {
    new Livro(livro1.titulo,livro1.autor,livro1.genero,livro1.ano),
    new Livro(livro2.titulo,livro2.autor,livro2.genero,livro2.ano),
    new Livro(livro3.titulo,livro3.autor,livro3.genero,livro3.ano),
    new Livro(livro4.titulo,livro4.autor,livro4.genero,livro4.ano),
    new Livro(livro5.titulo,livro5.autor,livro5.genero,livro5.ano),
    new Livro(livro6.titulo,livro6.autor,livro6.genero,livro6.ano)
};

        //Ordena por ano de publicação
        Livro.OrdenaPorAno(livros);

        Console.WriteLine("\nLivros ordenados por ano de publicação:");
        foreach (var livro in livros)
        {
            Console.WriteLine($"Título: {livro.titulo}, Ano: {livro.ano}");
        }


        //Buscando o autor do livro conforme título
        Console.WriteLine("O autor do Livro " + livro1.titulo + " é " + livro1.QualAutorLivro());
        Console.WriteLine("O autor do Livro " + livro2.titulo + " é " + livro2.QualAutorLivro());
        Console.WriteLine("O autor do Livro " + livro3.titulo + " é " + livro3.QualAutorLivro());
        Console.WriteLine("O autor do Livro " + livro4.titulo + " é " + livro4.QualAutorLivro());
        Console.WriteLine("O autor do Livro " + livro5.titulo + " é " + livro5.QualAutorLivro());
        Console.WriteLine("O autor do Livro " + livro6.titulo + " é " + livro6.QualAutorLivro());

        //veriricação da frequencia do livro
        var frequencioGenero = 0;
        foreach (var livro in livros)
        {
            frequencioGenero += livro.qtdeGenero("Ficção");
        }

        Console.WriteLine("O quantidade do genero Ficção é : " + frequencioGenero);
    }
}