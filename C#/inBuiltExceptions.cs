
class Check{
    public static void checkAge(int age)
    {
        if(age<18)
        {
            throw new ArithmeticException("NOT ELIGIBLE TO GIVE VOTE...");
        }
        else{
            Console.WriteLine("ELIGIBLE TO GIVE VOTE...");
        }
    }
}