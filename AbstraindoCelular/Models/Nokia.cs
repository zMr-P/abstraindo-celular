

namespace AbstraindoCelular.Models
{
    internal class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string app, int memoria)
        {
            try
            {
                if (app.Length > 0 && memoria < _memoria)
                {
                    Console.WriteLine($"\nInstalando aplicativo {app}.");
                }
                else if (app.Length == 0)
                {
                    throw new Exception("\nAplicativo não reconhecido.");
                }
                else
                {
                    throw new Exception("\nCapacidade de memória insuficiente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public override string ToString()
        {
            return "Nokia";
        }
    }
}
