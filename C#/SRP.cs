class Vehicle{
    public string ?name{get;set;}
    public string ?color{get;set;}


}
class printDetails{
    
    public void VehicleDetails(Vehicle v){
        Console.WriteLine($"Vehicle Name: {v.name} Color: {v.color}");
    }
}