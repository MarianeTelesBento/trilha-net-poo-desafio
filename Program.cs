using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Console.WriteLine("\n");

Smartphone nokia = new Nokia("11970848954", "Modelo 1", "12121213213", 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Minecraft");
Console.WriteLine("\n");

Smartphone iphone = new Iphone("2314210483", "Modelo 4", "3804809283", 16);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tiko e Teko");
Console.WriteLine("\n");