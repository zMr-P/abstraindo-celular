
namespace AbstraindoCelular.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string _modelo { get; set; }
        protected string _imei { get; set; }
        protected int _memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }
        public void Ligar(Smartphone numero)
        {
            try
            {
                if (numero.Numero.Length > 0)
                {
                    Console.WriteLine("Ligação efetuada");
                }
                else
                {
                    throw new ArgumentException("Número não pode ser nulo");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ReceberLigacao(Smartphone numero)
        {
            try
            {
                if (numero.Numero.Length >= 11)
                {
                    Console.WriteLine("Recebendo ligação.");
                }
                else
                {
                    throw new ArgumentException("Ligação de telemarketing recusada!");
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public abstract void InstalarAplicativo(string app, int memoria);
    }
}
