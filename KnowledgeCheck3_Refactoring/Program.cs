
using KnowledgeCheck3_Refactoring;

var myDataClass = new MyDataClass();
var logicClass = new MyLogicClass();

var count = logicClass.AddVehicle(new Car
{
    BrandName = "Toyota",
    ColorName = "WHite",
    EngineType = "hybrid",
    ModelName = "Prius"
});

Console.WriteLine($"Add Prius.  There are now {count} cars in the database");
Console.WriteLine();

count = logicClass.AddVehicle(new Car
{
    BrandName = "Toyota",
    ColorName = "Black",
    EngineType = "inline 4",
    ModelName = "Rav4"
});

Console.WriteLine($"Added Rav4.  There are now {count} cars in the database");
Console.WriteLine();

Console.WriteLine("Getting all cars as vehicles...");
var vehicles = logicClass.GetAllCarsAsVehicles();
foreach (var vehicle in vehicles)
{
    Console.WriteLine(vehicle.ToString());
}
Console.WriteLine();

Console.WriteLine("The follow cars are hybrids: ");
var hybrids = logicClass.GetAllHybridCars();
foreach(var hybrid in hybrids)
{
    Console.WriteLine(hybrid.ModelName);
}
Console.WriteLine();