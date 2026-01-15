/*
Variable Scope Demonstration
Illustrates how variables declared at the program level are accessible
throughout the entire program, including inside code blocks like if statements.
Shows that variables maintain their values across different code blocks.
*/

// Declare a boolean flag at program scope (accessible throughout the program)
bool flag = true;

// Declare an integer at program scope with initial value of 0
// This variable can be accessed and modified anywhere in the program
int value = 0;

// Conditional block: Variables from outer scope (flag, value) are accessible inside
if (flag)
    // Access the 'value' variable from the outer scope
    // At this point, value is still 0 (its initial value)
    Console.WriteLine($"Inside the code block: {value}");

// Modify the value variable at program scope (outside the if block)
// This demonstrates that variables persist after code blocks complete
value = 10;

// Access the modified value from program scope
// Shows that the variable retained its new value (10) after being modified
Console.WriteLine($"Outside the code block: {value}");