using System;

namespace Algoritimo2
{
    class Program
    {
        static void Main(string[] args)
        {



            ControleAcesso controleAcesso = new ControleAcesso();

            bool logado = controleAcesso.EfetuarLogin();

            if (logado)
                Console.WriteLine("LOGIN EFETUADO COM SUCESSO!");

            // Números Primos

            //Console.WriteLine("Gerar números primos até o número informado, digite um número:");
            //int limite = Convert.ToInt32( Console.ReadLine());

            //int[] indices = new int[4];
            //indices[0] = 2;
            //indices[1] = 3;
            //indices[2] = 5;
            //indices[3] = 7;



            //for (int l = 0; l <= limite; l++) // varrer até a limite informado
            //{
            //    bool primo = true;
            //    for (int i = 0; i < 4; i++)
            //    {
            //        int resto = l % indices[i];
            //        if (l != indices[i] && resto == 0)
            //        {
            //            primo = false;
            //            break;
            //        }

            //    }   
            //    if (primo)
            //    {
            //        Console.WriteLine(l);

            //    }
            //}



            // Calculo IMC
            //Console.WriteLine("Digite seu peso em KG:");
            //int peso = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite sua altura em metros:");
            //double altura = Convert.ToDouble( Console.ReadLine());

            //double imc = peso / (altura * altura);
            //Console.WriteLine($"imc: {imc}");

            //string resultado = "";

            //if (imc < 17) resultado = "Muito abaixo do peso!";
            //if (imc >= 17 && imc  < 18.49) resultado = "Abaixo do peso!";
            //if (imc >= 18.49 && imc < 25) resultado = "Peso normal!";
            //if (imc >= 25 && imc < 30) resultado = "Acima do Peso";
            //if (imc >= 30 && imc < 35) resultado = "Obesidade I";
            //if (imc >= 35 && imc < 40) resultado = "Obesidade II (Severa)";
            //if (imc >= 40) resultado = "Obesidade III (Morbida)";

            //Console.WriteLine(resultado);

        }
    }
}
