using System;

namespace aula0610
{
    class Program
    {
        static void Main(string[] args)
        {      
            string[,] dados = new string[11,2]{{"nome",""},
                                               {"endereco",""},
                                               {"cidade",""},
                                               {"estado",""},
                                               {"cep",""},
                                               {"cpf",""},
                                               {"rg",""},
                                               {"data de nascimento",""},
                                               {"sexo",""},
                                               {"estado civíl",""},
                                               {"profissão",""}};
                                               
            for (int i = 0; i <= dados.GetUpperBound(0); i++)
            {
                Console.WriteLine("Digite a seguinte informação: " + dados[i,0]); 
                dados[i,1] = Console.ReadLine();
            }

            Console.WriteLine("Você se chama {0}, mora em {1}, cidade {2}, estado {3}, cep {4}, seu cpf é {5}, seu rg é {6}, nasceu em {7}, sexo {8}, está {9}, e é {10}", dados[0,1], dados[1,1], dados[2,1], dados[3,1], dados[4,1], dados[5,1], dados[6,1], dados[7,1],dados[8,1], dados[9,1], dados[10,1] );
            Console.Read();     


        }
    }
}
