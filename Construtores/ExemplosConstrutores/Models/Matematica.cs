namespace ExemplosConstrutores.Models
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Matematica(int x, int y)
        {
            X = x;
            Y = y;
            Calculadora.EventoCalculadora += EventMandler;
        }
        public void Somar() => Calculadora.Somar(X, Y);
        public void Subtrair() => Calculadora.Subtrair(X, Y);

        public void EventMandler()
        {
            System.Console.WriteLine("Metodo executado");
        }
    }
}