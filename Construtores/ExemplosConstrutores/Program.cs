using System.Data.Common;
using System;
using ExemplosConstrutores.Models;

namespace ExemplosConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Matematica m = new Matematica(456, 20);
            m.Somar();
            m.Subtrair();

            //Operacao op = Calculadora.Somar;
            //Operacao op = new Operacao(Calculadora.Subtrair);
            //op += Calculadora.Somar; //Multi Cast Delegate
            //op.Invoke(30, 10);
            //op(300, 10);

            //const double pi = 3.14;

            

            //System.Console.WriteLine(pi);
            //Data data = new Data();
            //data.SetMes(32);

            //data.Mes = 42;
            //System.Console.WriteLine(data.Mes);

            //data.ApresentarMes();


            // Aluno p1 = new Aluno("Eduardo", "Pereira", "Ciências");
            // p1.Apresentar();

            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste Instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2);

        }
    }
}
