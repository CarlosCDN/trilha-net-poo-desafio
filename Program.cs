using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Criar uma instância da classe Iphone
        Console.Write("Digite o número do Iphone: ");
        string numeroIphone = Console.ReadLine();

        Console.Write("Digite o modelo do Iphone: ");
        string modeloIphone = Console.ReadLine();

        Console.Write("Digite o IMEI do Iphone: ");
        string imeiIphone = Console.ReadLine();

        Console.Write("Digite o memoria do Iphone: ");
        int memoriaIphone = int.Parse(Console.ReadLine());

        Console.Write("Digite o APP do Iphone para download: ");
        string appIphone = Console.ReadLine();

        Iphone iphone = new Iphone(numeroIphone, modeloIphone, imeiIphone, memoriaIphone);
        Console.WriteLine($"Número Iphone: {iphone.Numero}\nModelo Iphone: {iphone.Modelo}\nImei Iphone: {iphone.Imei}\nMemoria Iphone: {iphone.Memoria}");

        iphone.Ligar();
        iphone.ReceberLigacao();

        iphone.InstalarAplicativo(appIphone);



        //Nokia
        Console.Write("Digite o número da Nokia: ");
        string numeroNokia = Console.ReadLine();

        Console.Write("Digite o modelo da Nokia: ");
        string modeloNokia = Console.ReadLine();

        Console.Write("Digite o IMEI da Nokia: ");
        string imeiNokia = Console.ReadLine();

        Console.Write("Digite o memoria da Nokia: ");
        int memoriaNokia = int.Parse(Console.ReadLine());

        Console.Write("Digite o APP da Nokia para download: ");
        string appNokia = Console.ReadLine();


        // Chamar métodos da classe base
        Nokia nokiaPhone = new Nokia(numeroNokia, modeloNokia, imeiNokia, memoriaNokia);


        nokiaPhone.Ligar();
        nokiaPhone.ReceberLigacao();

        Console.WriteLine($"Número Nokia: {nokiaPhone.Numero}\nModelo Nokia: {nokiaPhone.Modelo}\n" +
            $"Imei Nokia: {nokiaPhone.Imei}\nMemoria Nokia: {nokiaPhone.Memoria}");
        // Testar o método InstalarAplicativo da classe derivada Nokia
        nokiaPhone.InstalarAplicativo(appNokia);

        Console.ReadLine();
    }
}
