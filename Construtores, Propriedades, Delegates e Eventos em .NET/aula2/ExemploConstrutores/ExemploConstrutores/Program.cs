using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();



            ////Operacao op = Calculadora.Somar;
            //Operacao op = new Operacao(Calculadora.Somar);
            //op += Calculadora.Substrair;

            ////op(10, 10);
            //op.Invoke(10, 10);
            



            //const double pi = 3.14;
            //Console.WriteLine(pi);
            ////pi = 0;



            //Data data = new Data();
            ////data.SetMes(20);

            //data.Mes = 5;

            //data.ApresentarMes();



            //Aluno al1 = new Aluno("Teste", "TT", "T");
            //al1.Apresentar();



            //Log log = Log.GetInstance();
            //log.PropriedadeLog = "Teste instancia";

            //Log log2 = Log.GetInstance();
            //Console.WriteLine(log2.PropriedadeLog);



            //Pessoa p1 = new Pessoa("ABC", "CBA");
            //p1.Apresentar();
        }
    }
}