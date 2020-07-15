using System;

namespace Algoritimo2
{
    class Program
    {
        static void Main(string[] args)
        {



            //ControleAcesso controleAcesso = new ControleAcesso();
            //bool logado = controleAcesso.EfetuarLogin();
            //if (logado)
            //    Console.WriteLine("LOGIN EFETUADO COM SUCESSO!");

            // Números Primos

            //NumerosPrimos numerosPrimos = new NumerosPrimos();
            //Console.WriteLine("Gerar números primos até o número informado, digite um número:");
            //numerosPrimos.Limites = Convert.ToInt32(Console.ReadLine());
            //numerosPrimos.CalcularNumerosPrimos();








            // Calculo IMC

            Imc imc = new Imc();
            Console.WriteLine("Digite seu peso em KG:");
            imc.Peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua altura em metros:");
            imc.Altura = Convert.ToDouble( Console.ReadLine());

            Console.WriteLine (imc.calculaImc());



            //Console.WriteLine(resultado);

        }
    }
}
