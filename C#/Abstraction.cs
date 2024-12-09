abstract class Abst{
    public abstract void showDetails();
    public void showMessage(){
        Console.WriteLine("This is a message");
    }

}

class XYZ:Abst{
    public override void showDetails(){
        Console.WriteLine("Here are Details");
    }
}
