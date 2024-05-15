using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("Nokia Tijolão", "41999999999", "21212112" , 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("Iphone 15 Pro Max", "4288888888", "8754785465", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");