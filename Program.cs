using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "7988436", modelo: "Modelo 2", imei: "55555555555", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");