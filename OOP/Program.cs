

// Create an instance of the Human class for Richard
Human richard = new Human();

// Create an instance of the Human class for Kemar
Human kemar = new();

class Human
{
    // Member variables to store the first name, last name, and age of the human
    string FirstName;
    //string LasttName;
    //int Age;

    // Method to introduce oneself with the first name
    public void IntruduceMySelf()
    {
        Console.WriteLine($"My name is {FirstName}");
    }

    // Method to introduce oneself with the full name and age
    //public void IntruduceMySelf2()
    //{
    //    Console.WriteLine($"My name is {FirstName} {LasttName} and I am {Age} years old");
    //}

    // Default constructor
    //public Human()
    //{
    //    // No initialization needed
    //}

    // Parameterized constructor to initialize the member variables
    //public Human(string firstNmae, string lasttName, int age)
    //{
    //    FirstName = firstNmae;
    //    LasttName = lasttName;
    //    Age = age;
    //}
}
