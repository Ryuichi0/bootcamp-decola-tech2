using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            //data.SetMes(20);

            data.Mes = 5;

            data.ApresentarMes();





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