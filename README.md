# Car Factory - Weekly 5 Closing

This is a C# Console Application simulating a car production factory. Users can produce cars with specified properties and manage them using a user-friendly interface. The program demonstrates fundamental programming concepts such as object-oriented design, exception handling, and user input validation.

## Features

1. **Car Production**:
   - Users can create cars with the following properties:
     - **Production Date**: Automatically set to the current date and time.
     - **Serial Number**: User-provided unique identifier for the car.
     - **Brand**: User-provided brand of the car.
     - **Model**: User-provided model of the car.
     - **Color**: User-provided color of the car.
     - **Number of Doors**: Validated user input for door count.
   - Invalid inputs for the number of doors prompt an error and request the input again.

2. **Looping Mechanism**:
   - Users can create multiple cars until they choose to stop.
   - Invalid responses are handled gracefully, and the program loops back for valid input.

3. **Car List Display**:
   - At the end of the program, a list of all produced cars is displayed with their **Serial Number** and **Brand**.

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
- Basic understanding of C# programming, including object-oriented principles.

## How to Run

1. Clone this repository or download the source code.
2. Open the project in an IDE such as Visual Studio or Visual Studio Code.
3. Build and run the application.

## How It Works

1. The program asks the user if they want to produce a car.
   - Respond with **`e`** (yes) or **`h`** (no).
   - The input is case-insensitive.
   - Invalid responses will prompt the same question again.

2. If the user chooses to produce a car:
   - The program collects details for the car (e.g., serial number, brand, model, color, and number of doors).
   - The car is added to a list of produced cars.

3. Users can create additional cars or exit the program.

4. When exiting, the program displays the list of all produced cars with their **Serial Number** and **Brand**.

## Example Usage

### Valid Input:

Do you want to produce a car? (e/h): e Enter the serial number: 12345 Enter the brand: Toyota Enter the model: Corolla Enter the color: White Enter the number of doors: 4 Do you want to produce another car? (e/h): h Exiting program. Here are the cars produced: Serial Number: 12345, Brand: Toyota

### Invalid Input:

Do you want to produce a car? (e/h): x Invalid response! Please answer with 'e' or 'h'. Do you want to produce a car? (e/h): e Enter the serial number: 67890 Enter the brand: Ford Enter the model: Focus Enter the color: Blue Enter the number of doors: abc Invalid input! Please enter a positive numeric value. Enter the number of doors: 4 Do you want to produce another car? (e/h): h Exiting program. Here are the cars produced: Serial Number: 67890, Brand: Ford

## Project Structure

CarFactory/
Program.cs // Main application logic
Car.cs // Defines the Car class with properties and initialization logic


## Concepts Demonstrated

1. **Object-Oriented Programming**:
   - Encapsulation of car properties in the `Car` class.
   - Constructor to automatically set the production date.

2. **Exception Handling**:
   - Use of `int.TryParse` to validate numeric input for the door count.

3. **User Input Validation**:
   - Ensures valid responses for all prompts.
   - Gracefully handles invalid input using loops and `goto`.

4. **Dynamic Lists**:
   - Efficiently manages produced cars using a `List<Car>`.

## Contribution

Feel free to fork the repository, make improvements, and submit a pull request. Contributions are always welcome!

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Author

Created by Batuhan Uzun
