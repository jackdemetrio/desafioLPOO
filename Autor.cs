public class Autor {
    public string Nome;
    public string Nacionalidade;

    //Construtor 
    public Autor (string nome, string nacionalidade) {
        Nome = nome;
        Nacionalidade = nacionalidade;
    }

    public void MostrarInfo(){
        Console.WriteLine($"Nome: {Nome}, Nacionalidade: {Nacionalidade}");
    }
}