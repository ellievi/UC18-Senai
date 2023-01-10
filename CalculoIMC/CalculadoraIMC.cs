namespace CalculoIMC
{
    public class CalculadoraIMC
    {
        public static string CalcularIMC(double kg, double altura)
        {
            double resultado = kg / (altura * altura);

            if (resultado < 18.5)
            {
                return "Abaixo do peso";
            }
            if (resultado < 24.9)
            {
                return "Peso nomal";
            }
            if (resultado < 29.9)
            {
                return "Sobre peso";
            }
            if (resultado < 34.9)
            {
                return "Obesidade grau 1";
            }
            if (resultado < 39.9)
            {
                return "Obesidade grau 2";
            }
            else
            {
                return "Obesidade grau 3";
            }
        }

    }
}