# csharp-variable-scope

A C# console application demonstrating variable scope and lifetime in different code blocks.

## Description

This program illustrates fundamental concepts of variable scope in C#:
- Variables declared outside code blocks are accessible throughout the program
- How variables maintain their values across different code blocks
- The difference between variable declaration scope and variable lifetime
- Reading and modifying variables in conditional statements

## How It Works

The program declares two variables at the program scope level:
1. **flag**: A boolean that controls conditional execution
2. **value**: An integer that is accessed and modified across code blocks

The program demonstrates that:
- Variables declared at the outer scope can be accessed inside if statements
- Variables retain their values after exiting code blocks
- Values can be modified after conditional blocks execute

## How to Run

```bash
dotnet run
```

## Example Output

```
Inside the code block: 0
Outside the code block: 10
```

## Concepts Demonstrated

### Variable Scope
- **Program-level Scope**: Variables declared at the top level are accessible throughout the program
- **Block-level Access**: Inner code blocks (like if statements) can read and write outer scope variables
- **Variable Lifetime**: Variables exist for the entire duration of the program execution

### Code Flow
1. Declare `flag` (true) and `value` (0) at program scope
2. Enter if block (condition is true)
3. Access and print `value` inside the block (shows 0)
4. Exit if block
5. Modify `value` to 10 at program scope
6. Print `value` outside the block (shows 10)

## Key Learning Points

### Scope Rules
- Variables declared outside blocks are accessible inside blocks
- Variables declared inside blocks are NOT accessible outside those blocks
- Outer scope variables persist after inner blocks complete

### Comparison: What Would Fail

This code would **fail** because `innerValue` is scoped to the if block:
```csharp
if (flag)
{
    int innerValue = 5;  // Only exists inside this block
    Console.WriteLine(innerValue);
}
Console.WriteLine(innerValue);  // ERROR: innerValue doesn't exist here
```

### Best Practices
- **Declare variables at the appropriate scope**: Minimize scope to reduce errors
- **Initialize before use**: Always initialize variables before accessing them
- **Understand block boundaries**: Code between `{}` creates a new scope
- **Avoid shadow variables**: Don't redeclare variables with the same name in inner scopes

## Visual Scope Representation

```
Program Scope (Outer)
├── bool flag = true
├── int value = 0
│
├── if (flag) { ──────────── If Block Scope (Inner)
│   │
│   └── Can access: flag, value
│   }
│
└── Can access: flag, value
```

## Real-World Applications

Understanding variable scope is critical for:
- **Error Prevention**: Avoiding accidental variable access/modification
- **Memory Management**: Variables are cleaned up when they go out of scope
- **Code Organization**: Properly structuring code with appropriate variable lifetimes
- **Function Design**: Understanding parameter passing and local variables
- **Loop Optimization**: Knowing when loop variables are accessible
- **Debugging**: Tracking where variables are created and destroyed

## Common Scope-Related Errors

1. **Using undeclared variables**: Accessing variables before declaration
2. **Scope leakage**: Trying to access block-scoped variables outside their block
3. **Shadowing**: Declaring variables with the same name in nested scopes
4. **Uninitialized variables**: Reading variables before assigning values

## Extended Example

```csharp
int x = 10;                    // Outer scope

if (x > 5)
{
    int y = 20;                // Inner scope
    x = x + y;                 // Can access both x and y
    Console.WriteLine(x);      // 30
}

Console.WriteLine(x);          // 30 (x persists)
// Console.WriteLine(y);       // ERROR: y is out of scope
```
