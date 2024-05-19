using DesafioPOO.Models;

Console.WriteLine("Celular Nokia");
Nokia nokia = new Nokia(numero: "(11) 98014-8892",imei: "123456789012345",memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Celular Iphone");
Iphone iphone = new Iphone(numero: "(64) 98003-8653",imei: "356789012345678",memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");