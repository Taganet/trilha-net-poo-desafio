using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

//Inicializando Nókia
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("11 12345-6789", "N95", "0123045607890", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("11 98765-4321", "Iphone 8", "0012004500780", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
iphone.ReceberLigacao();

Console.WriteLine("\n");