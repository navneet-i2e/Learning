interface IDetails{
     void getDetails(int id,string name);
}

class ABC:IDetails{
    public void getDetails(int id ,string name){
        Console.WriteLine($"ID: {id} Name: {name}");
    }
}


//multiple inheritance not possible in C# hence use multiple interfaces


interface IEmpDetails{
    void showEmpDetails(int id,string name,string dept);

}
interface ISalary{
    void showSalary(int id,int salary);
}
class Employee:IEmpDetails,ISalary{
    public void showEmpDetails(int id,string name,string dept){
      Console.WriteLine("Here are Employee Details");
      Console.WriteLine($"ID:{id} Name:{name} Department:{dept}");
    }
    public void showSalary(int id ,int salary)
        {
Console.WriteLine($"Employee Salary: {salary} ");
        }
}