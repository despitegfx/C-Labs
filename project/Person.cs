abstract class Person{
    private string Name;
    private string energyLevel;
    private string caffeineCapacity;

    public Person(string name, string energylevel, string caffeinecapacity)
    {
        Name = name;
        energyLevel = energylevel;
        caffeineCapacity = caffeinecapacity;

    }

    public string Nmame { 
        get => Name; 
    
    }

    public string EnergyLevel1 { 
        get => EnergyLevel; 
        set => EnergyLevel = value; 
    }

    public string CaffeineCapacity { 
        get => caffeineCapacity; 
        set => caffeineCapacity = value; 
    }

    public abstract double Rating();
}