using Week5Closing.Models;

List<Car> carList = new List<Car>(); // List to store cars
string userInput;

while (true)
{
Start:
    // Ask the user if they want to produce a car
    Console.WriteLine("Do you want to produce a car? (e/h):");
    userInput = Console.ReadLine()?.Trim().ToLower();

    // Validate the user's input
    if (userInput == "h")
    {
        // Exit the program if the user does not want to produce a car
        Console.WriteLine("Exiting program. Here are the cars produced:");
        foreach (var car in carList)
        {
            Console.WriteLine($"Serial Number: {car.SerialNumber}, Brand: {car.Brand}");
        }
        break;
    }
    else if (userInput != "e")
    {
        // Handle invalid input
        Console.WriteLine("Invalid response! Please answer with 'e' or 'h'.");
        goto Start;
    }

    // Create a new car object
    Car newCar = new Car();

    // Set the serial number
    Console.WriteLine("Enter the serial number:");
    newCar.SerialNumber = Console.ReadLine();

    // Set the brand
    Console.WriteLine("Enter the brand:");
    newCar.Brand = Console.ReadLine();

    // Set the model
    Console.WriteLine("Enter the model:");
    newCar.Model = Console.ReadLine();

    // Set the color
    Console.WriteLine("Enter the color:");
    newCar.Color = Console.ReadLine();

// Set the number of doors
DoorInput:
    Console.WriteLine("Enter the number of doors:");
    if (!int.TryParse(Console.ReadLine(), out int doorCount) || doorCount <= 0)
    {
        // Handle invalid door count input
        Console.WriteLine("Invalid input! Please enter a positive numeric value.");
        goto DoorInput;
    }
    newCar.DoorCount = doorCount;

    // Add the new car to the list
    carList.Add(newCar);

    // Ask if the user wants to create another car
    Console.WriteLine("Do you want to produce another car? (e/h):");
    userInput = Console.ReadLine()?.Trim().ToLower();

    if (userInput == "h")
    {
        // Exit the program if the user does not want to produce another car
        Console.WriteLine("Exiting program. Here are the cars produced:");
        foreach (var car in carList)
        {
            Console.WriteLine($"Serial Number: {car.SerialNumber}, Brand: {car.Brand}");
        }
        break;
    }
    else if (userInput != "e")
    {
        // Handle invalid input for continuation
        Console.WriteLine("Invalid response! Returning to the main menu...");
        goto Start;
    }
}