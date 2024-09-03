using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "119999978000", modelo: "Nokia SA1", imei: "0000000001",128);
nokia.Ligar();
nokia.InstalarAplicativo("Google Maps");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "119999978000", modelo: "Iphone 15", imei: "0000000001",512);
iphone.Ligar();
iphone.InstalarAplicativo("Mercado Livre");




