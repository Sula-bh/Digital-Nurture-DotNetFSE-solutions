using BuilderPatternExample;

Computer gamingPC = new Computer.Builder()
    .SetCPU("Intel i9")
    .SetRAM(32)
    .SetStorage(1000)
    .Build();

Console.WriteLine("Gaming PC");
Console.WriteLine($"CPU: {gamingPC.CPU}");
Console.WriteLine($"RAM: {gamingPC.RAM} GB");
Console.WriteLine($"Storage: {gamingPC.Storage} GB");

Computer officePC = new Computer.Builder()
    .SetCPU("Intel i5")
    .SetRAM(8)
    .SetStorage(256)
    .Build();

Console.WriteLine("\nOffice PC");
Console.WriteLine($"CPU: {officePC.CPU}");
Console.WriteLine($"RAM: {officePC.RAM} GB");
Console.WriteLine($"Storage: {officePC.Storage} GB");