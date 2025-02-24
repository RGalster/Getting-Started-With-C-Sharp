//Canvert between different types which is know has casting or cast


//Implicit casting
int myInt = 7;
double myDouble = myInt;
Console.WriteLine("Implicit Casting");
Console.WriteLine($"myInt = {myInt}");
Console.WriteLine($"myDouble = {myDouble}");

Console.WriteLine("\n");
//Explicit casting 
myDouble = 7.7;
//Taking of the decimal
myInt = (int)myDouble;
Console.WriteLine("Explicit Casting");
Console.WriteLine($"myInt = {myInt}");
Console.WriteLine($"myDouble = {myDouble}");

Console.WriteLine("\n");

////Parse sting to int
string myString = "7";
//myInt = (int)myString; //This will not work
// We need to use parse
myInt = int.Parse(myString);
Console.WriteLine("Parse");
Console.WriteLine($"myString = {myString}");
Console.WriteLine($"myInt = {myInt}");

//Console.WriteLine("\n");
////Parse sting to double
myString = "7.7";
myDouble = double.Parse(myString);
Console.WriteLine($"myString = {myString}");
Console.WriteLine($"myDouble = {myDouble}");