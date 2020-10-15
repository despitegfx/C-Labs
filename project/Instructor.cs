class Instructor : Person{

    Student studentGrade = new Student();
    public abstract override double Rating(){
        return (studentGrade.Rating()*100);
    }

}