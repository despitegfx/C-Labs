class Instructor : Person{

    Student studentGrade = new Student();
    string name;
    string energyLevel;
    string caffeineCapacity;

   public Instructor() : base(name,energylevel,caffeinecapacity)
    {
        this.name = name;
        this.energyLevel = energylevel;
        this.caffeineCapacity = caffeinecapacity;
    }
   
    public void toString()
    {
        System.Console.WriteLine( name,energyLevel,caffeineCapacity);
    }
    

    public override double Rating(){
        return (studentGrade.Rating()*100);
    }

}