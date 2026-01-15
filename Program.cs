/*
Variable Scope and Array Processing Demonstration
Illustrates how variables declared at program scope are accessible and modifiable
across different code blocks (loops and conditionals).
Demonstrates the accumulator pattern and flag variables while processing an array.
*/

// Declare an array of integers at program scope
// This array is accessible throughout the entire program
int[] numbers = { 4, 8, 15, 16, 23, 42 };

// Declare an accumulator variable at program scope (initialized to 0)
// This will be modified inside the loop and accessed after the loop
int total = 0;

// Declare a flag variable at program scope (initialized to false)
// This will be set to true if we find the number 42 in the array
bool found = false;

// Iterate through each number in the array
// The outer scope variables (total, found) can be accessed and modified here
foreach (int number in numbers)
{
    // Accumulator pattern: Add each number to the running total
    // Modifying 'total' from outer scope - value persists after loop
    total += number;
    
    // Search pattern: Check if current number is 42
    // If found, set the flag variable from outer scope to true
    if (number == 42) found = true;
}

// Conditional check using the flag variable set in the loop
// This demonstrates that 'found' retained its value after the loop completed
if (found) Console.WriteLine("Set contains 42");

// Display the accumulated total from the loop
// This demonstrates that 'total' retained its final value after the loop completed
Console.WriteLine($"Total: {total}");