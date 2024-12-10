abstract class Shapes{
public abstract double CalculateArea();
}
class Circle:Shapes{
    public double radius{get;set;}
    public override double CalculateArea(){
        return 3.14*radius*radius;
    }
}
class Square:Shapes{

    public double side{get;set;}
    public override double CalculateArea(){
        return side*side;
    }
}
