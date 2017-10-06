using System;

namespace aula0610
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nome;
            string endereco;
            string cidade;
            string estado;
            string cep;
            string cpf;
            string rg;
            string dataNascimento;
            string sexo;
            string estadoCivil;
            string profissao;

            Console.WriteLine("DADOS CADASTRAIS\nDigite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu endereço");
            endereco = Console.ReadLine();

            Console.WriteLine("Digite o nome da sua cidade onde você mora");
            cidade = Console.ReadLine();

            Console.WriteLine("Digite o nome do estado onde você mora");
            estado = Console.ReadLine();

            Console.WriteLine("Digite o cep da rua onde você mora");
            cep = Console.ReadLine();

            Console.WriteLine("Digite o seu CPF");
            cpf = Console.ReadLine();
            
            Console.WriteLine("Digite o seu RG");
            rg = Console.ReadLine();

            Console.WriteLine("Digite a data do seu nascimento");
            dataNascimento = Console.ReadLine();

            Console.WriteLine("Digite seu sexo");
            sexo = Console.ReadLine();

            Console.WriteLine("Digite o seu estado civil");
            estadoCivil = Console.ReadLine();

            Console.WriteLine("Digite sua profissão");
            profissao = Console.ReadLine();

            Console.WriteLine("Você se chama {0}, mora em {1}, cidade {2}, estado {3}, cep {4}, seu cpf é {5}, seu rg é {6}, nasceu em {7}, sexo {8}, está {9}, e é {10}",nome, endereco, cidade, estado, cep, cpf, rg, dataNascimento, sexo, estadoCivil, profissao);
            
            Console.Read();            
        }
    }
}
