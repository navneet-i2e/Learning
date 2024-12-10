
//Hello World Porgram:-
// class Program{
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World");
//     }
// }

//Accecssing Variables:-

//1.option with creating instance of class
// class Program{
//     public static void Main(string[] args)
//     {
//         Console.WriteLine(Variables.number);
//         Console.WriteLine(Variables.firstName);
//         Console.WriteLine(Variables.isAdult);
//         Console.WriteLine(Variables.cgpa);
//         Console.WriteLine(Variables.grade);
//     }
// }

//2.option by creating instance of class
// class Program{
//     public static void Main(string[] args)
//     {
//         Variables myVar=new Variables();
//         Console.WriteLine(myVar.number);
//         Console.WriteLine(myVar.firstName);
//         Console.WriteLine(myVar.isAdult);
//         Console.WriteLine(myVar.cgpa);
//         Console.WriteLine(myVar.grade);

//     }
// }

// class Program{
//     public static void Main(string[] args)
//     {
//         Console.WriteLine(Convert.ToString(TypeCasting.myInt));
//         Console.WriteLine(Convert.ToDouble(TypeCasting.myInt));

//         Console.WriteLine(Convert.ToInt32(TypeCasting.myDouble));
//         Console.WriteLine(Convert.ToString(TypeCasting.myBool));

//     }
// }

// class Program{
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter your name:");
//         string ?myName=Console.ReadLine();                  //? makes myName nullable and it removes warning
//         Console.WriteLine("Hello, "+myName);

//         Console.WriteLine("Enter your age:");
//         int myAge=Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("You are "+myAge+" years old");

//     }
// }

// class Program{
//     public static void Main(string[] args)
//     {
//         Console.WriteLine(AddOperator.addition(10,20));
//         Console.WriteLine(SubOperator.subtraction(30,10));
//         Console.WriteLine(MulOperator.multiplication(10,20));
//         Console.WriteLine(DivOperator.division(30,10));
//         Console.WriteLine(ModOperator.modulus(30,10));
//         Console.WriteLine(IncreOperator.increment(10));
//         Console.WriteLine(DecreOperator.decrement(10));

//     }
// }


//in built math functions

// class Program{
//     public static void Main(string[] args)
//     {
//         Console.WriteLine(Math.Sqrt(25));
//         Console.WriteLine(Math.Pow(2,3));
//         Console.WriteLine(Math.Max(10,20));
//         Console.WriteLine(Math.Min(10,20));
//         Console.WriteLine(Math.Abs(-10));
//         Console.WriteLine(Math.Floor(10.7));
//         Console.WriteLine(Math.Ceiling(10.7));
//         Console.WriteLine(Math.Round(10.7));
//     }
// }


//strings


// class Program{
//     public static void Main(string[] args)
//     {
//         // string myName1="Hello ";
//         // string ?myName2=Console.ReadLine();
//         // string wholeName=myName1+myName2;
//         // Console.WriteLine(wholeName);

//         // //string inbuilt functions

//         // //to determine length of string

//         // Console.WriteLine(wholeName.Length);

//         // //to make string lower case

//         // Console.WriteLine(wholeName.ToLower());

//         // //to make string upper case

//         // Console.WriteLine(wholeName.ToUpper());

//         // //to check index of particular character

//         // Console.WriteLine(wholeName.IndexOf("e"));

//         //to concatenate string
//         // string ?name1="Navneet ";string ?name2="Anand";
//         // Console.WriteLine("Hello "+name1+name2);

//         // string ?name1="Navneet ";
//         // string ?name2="Anand";
//         // string wholeName=string.Concat(name1,name2);
//         // Console.WriteLine("Hello "+wholeName);

//         //by using + in addition it add but in strins it concatenate

//         //string interpolation
//         //  string ?name1="Navneet";string ?name2="Anand";
//         // Console.WriteLine($"Hello {name1} {name2}");

//         //to access strings

//         //strings are array of characters

//         // string ?name="Hello";
//         // Console.WriteLine(name[0]);


//         //to determine substring :-
//         //two built in methods substring() and IndexOf() can be used

//         // string ?Name="hello";
//         // int nameIndex=Name.IndexOf('l');
//         // string subName=Name.Substring(nameIndex);
//         // Console.WriteLine(subName);



//     }
//     }


// class Program{
//     static void Main(string[] args) {

//     //implementing condtional statements
//     Console.WriteLine("Enter Candidate Details:");
//     string ?firstName=Console.ReadLine();
//     string ?lastName=Console.ReadLine();
//     int age=Convert.ToInt32(Console.ReadLine());
//     if(IfElse.checkDetails(firstName,lastName,age))
//     {
//         Console.WriteLine("Eligible to vote.");
//     }
//     else{
//         Console.WriteLine("Not eligible to vote.");
//     }




//     }
// }

// class Program{
//     public static void Main(string[] args)
//     {   Console.WriteLine("Enter name:");
//         string ?Name=Console.ReadLine();
//         Console.WriteLine("Enter age:");
//         int age=Convert.ToInt32(Console.ReadLine());
//         if(age>=0 && age <=12)
//         {
//           Console.WriteLine($"{Name} is a child");
//         }

//         else if(age>=13 && age<=19)
//         {
//          Console.WriteLine($"{Name} is a teenager");
//         }
//         else{
//              Console.WriteLine($"{Name} is an adult");
//         }

//     }
// }
//above thing can also be achieved by ternary operator(condtional operator)


// class Program{
//     public static void Main(string[] args)
//     { Console.WriteLine("Enter Name:");
//     string ?Name=Console.ReadLine();
//     Console.WriteLine("Enter Age:");
//     int age=Convert.ToInt32(Console.ReadLine());
//     string ?result=age>=0 && age<=12 ?"Child":age>=13 && age<=18?"Teenager":"Adult";
//   Console.WriteLine($"{Name} is a {result}");




//     }
// }
// class Program{  
//     public static void Main(string[] args) {

//      Console.WriteLine("Enter month number:");
//      int monthNumber=Convert.ToInt32(Console.ReadLine());
//      Console.WriteLine(SwitchCase.getMonth(monthNumber));

// }}


//using for loop
//class Program
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a number:");
//        int number = Convert.ToInt32(Console.ReadLine());
//        ForLoop.printNumber(number);
//    }
//}

//using while loop
//class Program
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a number:");
//        int number = Convert.ToInt32(Console.ReadLine());
//        WhileLoop.printNumber(number);
//    }
//}

//using do while

// class Program{
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter a number:");
//         int number=Convert.ToInt32(Console.ReadLine());
//         DoWhileLoop.printNumber(number);
//     }
// }


// class Program{
//     public static void Main(string[] args)
//     {
//         for(int i=1;i<=10;i++)
//         {   if(i%2!=0)
//             {continue;}
//            if(i==8){
//             break;
//            }
//            else{
//                 Console.WriteLine(i);
//            }

//         }
//     }
// }

//bool concept

// class Program{
//     public static void Main(string[] args)
//     {

//     }
// }

//Arrays:-

// class Program{public static void Main(string[] args) {

//     int[] numbers={10,20,30,40,50};
//     Console.WriteLine("Array elements:");
//     // for(int i=0;i<numbers.Length;i++)
//     // {
//     //     Console.WriteLine(numbers[i]);
//     // }

//     //for each loop can be used in array
//     foreach(int number in numbers)
//     {
//         Console.WriteLine(number);
//     }
// }
// }


// class Program{
//     public static void Main(string[] args){
//     //   // string[] names=["Navneet","Anand","Rajesh","Priya","Shubham"];

//     // //    string[] names=new string[5]{"Navneet","Anand","Rajesh","Priya","Shubham"};

//     // //    string[]names=new string[]{"Navneet","Anand","Rajesh","Priya","Shubham"};

//     // string[] names=new string[5];
//     // Console.WriteLine("Enter name:");
//     // for(int i=0;i<names.Length;i++)
//     // {

//     //  names[i]=Console.ReadLine()!;              //supressing warning

//     // }
//     // Console.WriteLine("Names List:-");
//     // foreach(string i in names)
//     // {
//     //     Console.WriteLine(i);
//     // }

//     //sorting in array works in alphabetically or ascending order

// // for number
// // int[] numbers={5,4,3,2,1};
// // Array.Sort(numbers);                             //inbuilt method


// // foreach(int i in numbers)
// // {
// //     Console.WriteLine(i);

// // }

// // for string
// // string[]letters={"E","C","A","D","B"};
// // Array.Sort(letters);
// // foreach(string i in letters)
// // {
// //     Console.WriteLine(i);
// // }



// //for descending order or non-alphabetical order  use two functions sort and reverse
// int[] numbers={5,1,3,2,4};
// string[]letters={"E","C","A","D","B"};
// Array.Sort(numbers);Array.Reverse(numbers);
// Array.Sort(letters);Array.Reverse(letters);

// foreach(int i in numbers)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine();
// foreach(string i in letters)
// {
//     Console.WriteLine(i);
// }

//     }
// }

//more inbuilt functions
// class Program{
//     public static void Main(string[] args)
//     {
//         int[]numbers={5,1,3,2,4};
//         Console.WriteLine(numbers.Max());
//         Console.WriteLine(numbers.Min());
//         Console.WriteLine(numbers.Sum());



//     }
// }


//2D ARRAY



// class Program{
//     public static void Main(string[] args)
//     {
//         int a=MethodOverloading.add(10,20);
//         string b=MethodOverloading.add("Hello","World");
//         float c=MethodOverloading.add(40.5f,14.5f);
//         double d=MethodOverloading.add(30.5,20.6);

//         Console.WriteLine(a);
//         Console.WriteLine(b);
//         Console.WriteLine(c);
//         Console.WriteLine(d);

//     }
// }


// OOPS concepts:-


// class Program{
//     public static void Main(string[] args)
//     { 
//         Person p1=new Person();
//         Console.WriteLine(p1.firstName);
//         Console.WriteLine(p1.lastName);
//         Console.WriteLine(p1.age);


//     }
// }

// class Program{
//     public static void Main(string[] args)
//     {
//         CarModel myCar=new CarModel();
//         myCar.showDetails();

//     }
// }
// class Program{
//     public static void Main(string[] args)
//     {
//        Constructor C1=new Constructor();
//     Constructor C2=new Constructor("Rahul",26);

//     }
// }


//class Program
//{
//    public static void Main(string[] args)
//    {
//        Score s1 = Score.mid;
//        Console.WriteLine(s1);
//    }
//}

// class Program{
//     public static void Main(string[] args)
//     {
//         int m1=(int)Month.dec;
//         switch(m1)
//         {
//             case 1:Console.WriteLine("January");break;
//             case 2:Console.WriteLine("February");break;
//             case 3:Console.WriteLine("March");break;
//             case 4:Console.WriteLine("April");break;
//             case 5:Console.WriteLine("May");break;
//             case 6:Console.WriteLine("June");break;
//             case 7:Console.WriteLine("July");break;
//             case 8:Console.WriteLine("August");break;
//             case 9:Console.WriteLine("September");break;
//             case 10:Console.WriteLine("October");break;
//             case 11:Console.WriteLine("November");break;
//             case 12:Console.WriteLine("December");break;
//         }
//     }
// }


// class Program
// {
//     public static void Main(string[] args)
//     {
//         Dog myDog = new Dog();
//         myDog.makeSound();
//         myDog.bark();
//     }
// }


//exception handling

// class Program{
//     public static void Main(string[] args)
//     {
//         try{
//             int[]arr={10,20,30,40,50};
//             Console.WriteLine(arr[8]);
//         }
//         catch(Exception e)
//         {
//             Console.WriteLine(e.Message);
//             //instead of writing e.Message(default msg) we can write our own message.
//             // Console.WriteLine("An error occurred while accessing the array.");
//         }
//         finally{
//             Console.WriteLine("try catch block is finished");
//         }
//     }
// }

//inbuilt exception classes

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Check.checkAge(10);
//    }
//}


// class Program
// {

// public static void Main(string[] args){

//   Abst myAbst=new XYZ();
//   myAbst.showDetails();
//   myAbst.showMessage();

// }
// }


//single Inheritance
// class Program{
//     public static void Main(string[] args)
//     {
//         ABC myABC=new ABC();
//         myABC.getDetails(101,"Navneet");
//     }
// }

//multiple inheritance

// class Program{
//     public static void Main(string[] args)
//     {
//        Employee myEmp=new Employee();
      
//          myEmp.showEmpDetails(101,"Rajesh","IT");
//          myEmp.showSalary(101,26000);
//     }
// }


//Method Overriding

// class Program{
//   public static void Main(string[] args)
//  {
//  Father myFather=new Father();
//  Father mySon=new Son();
//   Father myGrandSon=new GrandSon();

//   myFather.showJob();
//   mySon.showJob();
//   myGrandSon.showJob();
  
//  }
// }

class Program{

public static void Main(string[] args)
{
    Cricketer myCricketer=new Cricketer();
    myCricketer.Name="Virat Kohli";
    Console.WriteLine(myCricketer.Name);
}

}
