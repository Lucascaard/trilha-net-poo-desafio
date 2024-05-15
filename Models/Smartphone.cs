namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string _modelo;

        public string Modelo
        {
            get => _modelo;
            set => _modelo = value;
        }
        
        private string _imei;

        public string Imei
        {
            get => _imei;
            set => _imei = value;
        }

        private int _memoria;

        public int Memoria
        {
            get => _memoria;
            set => _memoria = value;
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            _memoria = memoria;
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        protected Smartphone()
        {
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}