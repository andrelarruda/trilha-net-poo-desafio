using DesafioPOO.Models;

System.Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("1234", "Nokia 2200", "98239823", 12);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
System.Console.WriteLine();

System.Console.WriteLine("iPhone");
Smartphone iphone = new Iphone("4321", "iPhone 12 Pro Max", "298348", 512);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Snapchat");
iphone.InstalarAplicativo("Opera");