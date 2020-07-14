using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritimo2
{
    class ControleAcesso
    {
        string login = "dlboschetti";
        string senha = "123456";

        public bool EfetuarLogin()
        {
            bool retorno = false;
            Console.WriteLine("Digite o login:");
            string loginDigitado = Console.ReadLine();



            if (login == loginDigitado)
            {
                int count = 0;
                while (count < 3)
                {
                    Console.WriteLine("Digite a senha:");
                    string senhaDigitada = Console.ReadLine();

                    if (senha == senhaDigitada)
                    {
                        retorno = true;
                        break;

                    }
                    count++;
                }
            }


            return retorno;
        }

        
    }
}
