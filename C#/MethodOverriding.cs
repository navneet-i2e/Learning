//runtime Polymorphism

class Father{
    public virtual void showJob(){
        Console.WriteLine("Father is a Retired From Army");
    }
}
class Son:Father{
    public override void showJob(){
        Console.WriteLine("Son is a Software Engineer");

    }

}
class GrandSon:Son{
    public override void showJob(){
        Console.WriteLine("GrandSon is a Student");

    }

}
