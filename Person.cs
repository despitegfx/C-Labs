using System.Collections.Specialized;

abstract class Person{

    public String name{set; get;}
    public String energyLevel{set; get;}
    public String caffieneCapacity{set; get;}

    public abstract double Rating();



}