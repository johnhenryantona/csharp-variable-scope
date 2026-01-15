# csharp-variable-scope

A C# console application demonstrating variable scope, lifetime, and accessibility across different code blocks while performing array operations.

## Description

This program illustrates fundamental concepts of variable scope in C# through a practical example:
- Variables declared at program scope are accessible throughout the entire program
- How variables maintain their values across different code blocks (loops, conditionals)
- Variables declared outside loops can be read and modified inside loops
- Demonstrating accumulator pattern and flag variables across scopes

The program performs two operations on an array of numbers:
1. **Sum Calculation**: Accumulates the total of all numbers
2. **Value Search**: Checks if a specific value (42) exists in the array

## How It Works

The program declares three variables at program scope:
1. **numbers**: An array of integers
2. **total**: An accumulator for summing values (starts at 0)
3. **found**: A flag to track if 42 is found (starts as false)

These variables are accessible both inside the foreach loop and in the subsequent conditional statements, demonstrating variable scope persistence.

## How to Run

```bash
dotnet run
```

## Example Output

```
Set contains 42
Total: 108
```

## Concepts Demonstrated

### Variable Scope
- **Program-level Scope**: Variables declared at the top level (`numbers`, `total`, `found`) are accessible throughout the program
- **Loop Access**: Outer scope variables can be read and modified inside loops
- **Block Independence**: Variables persist after loop execution completes
- **Multiple Block Access**: Same variables accessible in foreach loop and if statements

### Code Flow
1. Declare array `numbers` with values [4, 8, 15, 16, 23, 42]
2. Declare `total` (accumulator) and `found` (flag) at program scope
3. Enter foreach loop:
   - Access and modify `total` (add each number)
   - Check if current number is 42, modify `found` if true
4. Exit foreach loop
5. Check `found` flag in if statement (value persists from loop)
6. Display results using `found` and `total` (both retain their final values)

## Scope Visualization

```
Program Scope (Outer)
├── int[] numbers = {...}
├── int total = 0
├── bool found = false
│
├── foreach (int number in numbers) { ──── Loop Scope (Inner)
│   │
│   ├── Can READ: numbers, total, found
│   ├── Can WRITE: total, found
│   └── Local variable: number (only exists in loop)
│   }
│
├── if (found) { ──────────────────────── Conditional Scope
│   │
│   └── Can READ: found (value set in loop)
│   }
│
└── Can access: numbers, total, found (all persist after blocks)
```

## Key Learning Points

### Scope Rules Demonstrated
- ✅ Outer scope variables accessible inside loops
- ✅ Variables modified in loops retain their values after loop exits
- ✅ Multiple code blocks can access the same outer scope variables
- ✅ Loop variables (`number`) only exist within the loop

### Practical Patterns
- **Accumulator Pattern**: `total` accumulates values across loop iterations
- **Flag Pattern**: `found` tracks a condition discovered during iteration
- **Scope Persistence**: Values set in loops are available after the loop

## Real-World Applications

This pattern is fundamental in:
- **Data Processing**: Summing, averaging, or analyzing collections
- **Search Operations**: Finding specific values or conditions in datasets
- **Validation Logic**: Checking if data meets certain criteria
- **Report Generation**: Calculating totals and statistics
- **Game Development**: Tracking scores, flags, and states across game loops
- **Financial Applications**: Computing totals, finding transactions

## Common Use Cases

### Accumulator Pattern
```csharp
int sum = 0;  // Outer scope
foreach (int num in collection)
{
    sum += num;  // Modify outer variable
}
Console.WriteLine(sum);  // Use accumulated value
```

### Flag Pattern
```csharp
bool isValid = true;  // Outer scope
foreach (var item in items)
{
    if (!item.IsValid)
        isValid = false;  // Set flag in loop
}
if (isValid)  // Check flag after loop
    ProcessItems();
```

## What Would NOT Work

This would fail because `number` is scoped to the loop:
```csharp
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine(number);  // ERROR: 'number' doesn't exist here
```

## Extended Concepts

### Variable Lifetime
- `numbers`, `total`, `found`: Exist for entire program duration
- `number`: Created and destroyed each loop iteration

### Memory Implications
- Outer scope variables occupy memory until program ends
- Loop variables are cleaned up after each iteration
- Proper scoping helps with memory management and prevents errors
