class Student : Person{
    public string preferedSuject{set;get;}
    public string School{set;get;}
    public double Grades{
        set{
            gradeList[] grade;
            Grades = grade[5];
        }
        get
        {
            Grades = Grades;
        }
            }

    public string Listen(){
        return "";
    }

    public string takeTest(){
        return "";
    }

    public string attendLecture(){
        return "";
    }

    public override double Rating()
    {
        double averageGrade;
        for(int i=0; i<Grades; i++){
            
            int addGrades = addGrades+Grades;
            averageGrade = addGrades/Grades.Length();
        }
        return averageGrade;
    }


}
 
