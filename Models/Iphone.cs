namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, imei, modelo, memoria)
        {
        }


        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no Iphone.");

        }
    }
}