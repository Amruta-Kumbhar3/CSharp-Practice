/* Declare one variable of each type (int, double, char, string, bool) 
and print all five with labels. */

int age = 25;
double taxRate = 0.8;
char firstLatter = 'A';
string name = "Amruta";
bool isActive = true;

Console.WriteLine("My name is: "+name);
Console.WriteLine("My age is: "+age);
Console.WriteLine("first Alphabet of Name: "+ firstLatter);
Console.WriteLine("Is currently active on work: "+isActive);
Console.WriteLine("approved tax rate is: "+taxRate);


/* Declare an int and a double, add them together, and print the result — 
what type is the result? (int + double implicitly becomes double) */

int num1 = 25;
double num2 = 25.5;
double result = num1+num2;
Console.WriteLine(result);

// Constants
/* A const value cannot be changed after it's declared. */

const int maxScore = 100;
Console.WriteLine(maxScore);

// maxScore = 150;  // this would cause a compile error if uncommented