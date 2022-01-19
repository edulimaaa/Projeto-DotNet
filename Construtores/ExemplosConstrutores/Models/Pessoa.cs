namespace ExemplosConstrutores.Models
{
    public class Pessoa
    {
        private readonly string nome = "Aline";
        private readonly string sobrenome;

        

        // public Pessoa() //construtor sem parametro
        // {
        //     nome = string.Empty;
        //     sobrenome = string.Empty;
        // }
        public Pessoa(string nome, string sobrenome)  //construtor com parametro 
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor Pessoa");
        }
        public void Apresentar() => System.Console.WriteLine($"Olá meu nome é {nome} {sobrenome}");
    }
}