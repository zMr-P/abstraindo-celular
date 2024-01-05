

namespace AbstraindoCelular.Models
{
    internal class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string app, int memoria)
        {
            try
            {
                if (app.Length > 0 && memoria < _memoria)
                {
                    Console.WriteLine($"\nIniciando instalação do aplicativo {app}.");
                }
                else if (app.Length == 0)
                {
                    throw new Exception("\nNão foi possível reconhecer o aplicativo.");
                }
                else
                {
                    throw new Exception("\nMemória insuficiente.\nPor favor, recarregar a bateria do celular!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public override string ToString()
        {
            return "Iphone";
        }
    }
}
