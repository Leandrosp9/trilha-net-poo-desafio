using DesafioPOO.Models;

//Teste
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("(35)99987-9865", "1100", "111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("(35)98701-6178", "Iphone 12 Pro", "000000", 512);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");