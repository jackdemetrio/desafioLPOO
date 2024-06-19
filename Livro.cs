using System;

public class Livro {
    public string titulo;
    public Autor autor;
    public double preco;

    public Livro (string titulo, Autor autor) {
        this.titulo = titulo;
        this.autor = autor;
    }

    public Livro (string titulo, Autor autor, double preco) {
        this.titulo = titulo;
        this.autor = autor;
        this.preco = preco;
    }
    public void MostrarInfo(){
        Console.WriteLine($"Titulo: {titulo}, Autor: {autor.Nome}, Preco: {preco}");
    }

    public void AplicarDesconto (double porcentagem){
        preco -= preco *(porcentagem / 100);
    }
    public void AplicarDesconto (int ValorFixo){
        preco -= ValorFixo;
    }
}