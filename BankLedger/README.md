# CSCI 1260 Assignment 1 - Bank Ledger

Name: Madison Honeycutt
Section: 002

## How to Run

Open the project in Visual Studio and run the console application.

## Assignment Status

Completed.

Anything unfinished: None.

## Concepts I Researched in Order to Complete this Assignment

There were a few topics in this assignment that had not been covered in my previous 1250 course. I had to research these topics in order to complete the assignment so I could understand how they worked.

### Read-Only Properties

I had not previously used C# properties with get accessors. I learned that public properties are a way to provide controlled access to private fields.

I also learned that properties can be accessed using dot notation. Before this assignment, I mainly associated dot notation with calling methods, so this was a new distinction for me.

I have not previously used set accessors either, so properties as a whole are still newer to me.

### String Formatting

I had not previously used composite string formatting such as "{0,4} {1,-12}". I researched how the numbered placeholders and alignment values worked.

I also learned that formatted placeholders can be used directly inside Console.WriteLine, including passing method results and property values into the formatted output.

### Method Overriding

I had not used method overriding in my previous course. I learned how override can be used with ToString() so an object can return a custom formatted string instead of its default representation.

### List<T>

I had not previously used List<T> in C#. I had to research how to create a List<T>, add Transaction objects to it, access its Count property, and loop through the objects stored in the list.

### Parallel Arrays and Driver Loop

I have experience using loops, but using a for loop to process two parallel arrays together was unfamiliar to me in this assignment.

I learned how matching indexes in the two arrays represent one request and how the same loop index can be used to access both arrays at the same time.

I used currentKind and currentAmount variables inside the loop because separating those values made the parallel array logic easier for me to follow and understand.

### Program Class and Main Method

My previous coursework used top-level statements in Program.cs, so I had not previously written an explicit Program class with a Main() method.

For this assignment, I researched that structure and learned that Main() is where program execution begins and that static allows Main() to run without creating a Program object.

### Output Spacing

The spacing shown in the PrintStatement() step table did not visually match the character-for-character expected output example. I adjusted the spacing in my statement heading, column headings, and summary formatting so the final console output matched the provided expected result exactly.