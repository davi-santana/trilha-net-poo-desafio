using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "450",modelo: "modelo1",imei:"11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("zap");

System.Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "8928", modelo: "modelo 2", imei: "2222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
