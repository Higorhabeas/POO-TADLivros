class Livro{
    public string titulo;
    public string autor;
    public string genero;
    public int ano;

    public Livro(){

    }

    public Livro(string titulo, string autor, string genero, int ano)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.genero = genero;
        this.ano = ano;
    }

    public string  getTitulo(){
        return this.titulo;
    }

    public string  getAutor(){
        return this.autor;
    }

    public string  getGenero(){
        return this.genero;
    }

    public int getAno(){
        return this.ano;
    }

    public void setLivro(string _titulo, string _autor, string _genero, int _ano){
        this.titulo = _titulo;
        this.autor = _autor;
        this.genero = _genero;
        this.ano = _ano;
    }

    public bool eModernismo(int _ano){
        if (_ano >= 1930 && _ano <= 1945){
            return true;
        }else{
            return false;
        }
    }

    public bool eBarroco(int _ano){
        if (_ano >= 1601 && _ano <= 1768){
            return true;
        }else{
            return false;
        }
    }

    public static void OrdenaPorAno(List<Livro> _livros){
        _livros.Sort((a,b) => a.ano.CompareTo(b.ano));
    }

    public string EscreverLivroCompleto(Livro _livroObj){
        return "\nTítulo: " +_livroObj.getTitulo() + 
                " Autor: " +_livroObj.getAutor() + 
                " Genero: " +_livroObj.getGenero() + 
                " Ano de publicação: " +_livroObj.getAno();
    }

    public string QualEstiloLiterario( int _ano){
        if(eBarroco(_ano)){
            return "O estilo literário deste livro é BARROCO!";
        }else if(eModernismo(_ano)){
            return "O estilo literário deste livro é MODERNISMO!";
        }else{
            return "O estilo literário deste livro é diferente de MODERNISMO e BARROCO!";
        }
    }

    public string QualAutorLivro(){
        return this.autor;
    }

    public int qtdeGenero(string _genero){
        
        if (getGenero() == _genero){
            return 1;
        }else{
            return 0;
        }
    }
}