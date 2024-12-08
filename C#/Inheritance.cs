

class Animal{
  public void makeSound(){
     string name1="ANIMAL";
      Console.WriteLine($"{name1} makes a sound");
  }
}
class Dog :Animal{
    public void bark(){
       string name2="DOG";
   Console.WriteLine($"{name2} makes Woof Woof Sound");
    }
}
//to stop inheritance from base class sealed keyword used.