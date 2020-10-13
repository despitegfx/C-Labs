class Student{

    private string name, preferedSuject, energyLevel, caffeineCapacity, school, grades;

    public Student(string name, string preferedSubject, string energyLevel, string caffeineCapacity, string school, string grades ){

        this.name = name;
        this.preferedSuject = preferedSubject;
        this.energyLevel = energyLevel;
        this.caffeineCapacity = caffeineCapacity; 
        this.school = school;
        this.grades = grades;
    }

    //getters
    public string getname(){
        return name;
    }

     public string getpreferedSuject(){
        return preferedSuject;
    }

     public string getenergyLevel(){
        return energyLevel;
    }

     public string getcaffeineCapacity(){
        return caffeineCapacity;
    }

     public string getschool(){
        return school;
    }

     public string getgrades(){
        return grades;
    }


    //methods
    public string Listen(){
        return "true";
    }

    public string takeTest(){

        return "true";
    }

    public string attendLecture(){
        return "true";
    }

}