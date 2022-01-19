namespace ExemplosConstrutores.Models
{
    public class Calculadora
    {
        //Delegate
        public delegate void DelegateCalculadora();

        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar(int x, int y)
        {
            if(EventoCalculadora != null)
            {
                System.Console.WriteLine($"Adição: {x} + {y} = {x+y}");
                EventoCalculadora();
            }
            else 
            {
                System.Console.WriteLine("Nenhum Inscrito!");
            }
            
        }
        public static void Subtrair(int x, int y)
        {
             if(EventoCalculadora != null)
            {
                System.Console.WriteLine($"Subtração: {x} + {y} = {x-y}");
                EventoCalculadora();
            }
            else 
            {
                System.Console.WriteLine("Nenhum Inscrito!");
            }
        }
    }
}