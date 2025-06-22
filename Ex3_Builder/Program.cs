using System;

public class Computer
{
    public string CPU { get; }
    public string RAM { get; }
    public string Storage { get; }
    public string? GraphicsCard { get; }
    public string? SoundCard { get; }
    public string? NetworkCard { get; }

    private Computer(string cpu, string ram, string storage, string? graphicsCard, string? soundCard, string? networkCard)
    {
        CPU = cpu;
        RAM = ram;
        Storage = storage;
        GraphicsCard = graphicsCard;
        SoundCard = soundCard;
        NetworkCard = networkCard;
    }

    public class ComputerBuilder
    {
        private readonly string _cpu;
        private readonly string _ram;
        private readonly string _storage;
        private string? _graphicsCard;
        private string? _soundCard;
        private string? _networkCard;

        public ComputerBuilder(string cpu, string ram, string storage)
        {
            _cpu = cpu;
            _ram = ram;
            _storage = storage;
        }

        public ComputerBuilder SetGraphicsCard(string graphicsCard)
        {
            _graphicsCard = graphicsCard;
            return this;
        }

        public ComputerBuilder SetSoundCard(string soundCard)
        {
            _soundCard = soundCard;
            return this;
        }

        public ComputerBuilder SetNetworkCard(string networkCard)
        {
            _networkCard = networkCard;
            return this;
        }

        public Computer Build()
        {
            return new Computer(_cpu, _ram, _storage, _graphicsCard, _soundCard, _networkCard);
        }
    }

    public void DisplayConfiguration()
    {
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"RAM: {RAM}");
        Console.WriteLine($"Storage: {Storage}");
        Console.WriteLine($"Graphics Card: {GraphicsCard ?? "None"}");
        Console.WriteLine($"Sound Card: {SoundCard ?? "None"}");
        Console.WriteLine($"Network Card: {NetworkCard ?? "None"}");
    }
}

class Program
{
    static void Main()
    {
        var gamingComputer = new Computer.ComputerBuilder("Intel i9", "32GB", "2TB SSD")
            .SetGraphicsCard("RTX 4090")
            .SetSoundCard("Creative Sound Blaster")
            .Build();

        Console.WriteLine("Gaming Computer Configuration:");
        gamingComputer.DisplayConfiguration();

        var officeComputer = new Computer.ComputerBuilder("Intel i5", "16GB", "512GB SSD")
            .Build();

        Console.WriteLine("\nOffice Computer Configuration:");
        officeComputer.DisplayConfiguration();

        var serverComputer = new Computer.ComputerBuilder("Xeon Platinum", "64GB", "10TB HDD")
            .SetNetworkCard("10Gb Ethernet")
            .Build();

        Console.WriteLine("\nServer Configuration:");
        serverComputer.DisplayConfiguration();
    }
}
