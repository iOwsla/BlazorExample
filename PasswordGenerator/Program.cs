using System.Text;
using System;
using PasswordGeneratorApp;

PasswordGenerator generator = new PasswordGenerator();

Console.WriteLine("Enter the length of the password to generate:");
string input = Console.ReadLine();
generator.Length = int.Parse(input);
string result = generator.Generate();

Console.WriteLine($"Your password is: {result}");
Console.ReadLine();