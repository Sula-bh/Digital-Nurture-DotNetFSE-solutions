using ProxyPatternExample.Images;

IImage image = new ProxyImage("landscape.jpg");

Console.WriteLine("Image created");
Console.WriteLine();

image.Display();

Console.WriteLine();

image.Display();
