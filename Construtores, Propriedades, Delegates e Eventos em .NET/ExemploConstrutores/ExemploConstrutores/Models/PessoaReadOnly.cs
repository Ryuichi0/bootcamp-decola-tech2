namespace ExemploConstrutores.Models
{
    public class PessoaReadOnly
    {
        private readonly string nome = "Leo";
        private readonly string sobrenome;

        public PessoaReadOnly()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public PessoaReadOnly(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome= sobrenome;
        }

        public void Apresentar()
        {
            //this.sobrenome = "Test";
            Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }
    }
}
