// class Constructor1{
//     public Constructor1()                   //default constructor
//     {
//         Console.WriteLine("Constructor 1 called");
//     }
// }

// class Constructor2{
//     public Constructor2(int x)              //parameterized constructor
//     {
//         Console.WriteLine($"Constructor 2 called and value is {x}");
//     }
// }

//another example of default and parameterized constructor

class Constructor{
    public Constructor(){
        Console.WriteLine($"Details is Unknown");
    }
    public Constructor(string name,int age)
    {
        Console.WriteLine($"Details of Person :- Name:{name } Age:{age}"); 
    }
}