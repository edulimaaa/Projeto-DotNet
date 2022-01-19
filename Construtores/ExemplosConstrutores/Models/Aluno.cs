namespace ExemplosConstrutores.Models
{
    public class Aluno : Pessoa //para instanciar precisamos se referir a base(class mãe) e passar os parametros para class mãe.
    {
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
        {
            System.Console.WriteLine("Construtor Aluno");
        }
    }
}