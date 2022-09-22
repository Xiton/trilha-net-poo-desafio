using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "998247246", modelo: "Modelo 1", imei:"1111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone");
Smartphone iphone = new Iphone(numero: "986728095", modelo: "Modelo 2", imei:"222222", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
