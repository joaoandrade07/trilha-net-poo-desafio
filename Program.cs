using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new("82912345678", "tijolão", "ab123", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Apple: ");
Iphone iphone = new("82912345679", "XR", "ab125", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");