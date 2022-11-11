namespace Prime.Services
{
    public class PrimeTemperature
    {
        public static class ConversorTemperatura
        {
            public static double FahrenheitParaCelsius(double temperatura)
                //=> (temperatura - 32) / 1.8; // Simulação de falha
                => Math.Round((temperatura - 32) / 1.8, 2);
        }
    }
}