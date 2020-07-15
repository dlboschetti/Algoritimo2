using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritimo2
{
    class Imc
    {

        public int Peso { get; set; }

        public double Altura { get; set; }

        public string calculaImc()
        {
            double imc = Peso / (Altura * Altura);
            string resultado = "";

            if (imc < 17) resultado = "Muito abaixo do peso!";
            if (imc >= 17 && imc < 18.49) resultado = "Abaixo do peso!";
            if (imc >= 18.49 && imc < 25) resultado = "Peso normal!";
            if (imc >= 25 && imc < 30) resultado = "Acima do Peso";
            if (imc >= 30 && imc < 35) resultado = "Obesidade I";
            if (imc >= 35 && imc < 40) resultado = "Obesidade II (Severa)";
            if (imc >= 40) resultado = "Obesidade III (Morbida)";
            return resultado;
        }

    }
}
