/* Implicit Conversion
No casting needed C# automatically converts int to double 
when assigning, since no data is lost going from a smaller 
type to a larger one. */

int myInt = 9;
double myDouble = myInt;
Console.WriteLine("Int value: "+myInt);
Console.WriteLine("double value: "+myDouble);


/* Explicit Casting
Declare a double, cast it to int using (int), and print both — 
confirm the decimal is lost. */

double val = 8.75;
int myInt1 = (int) val;
Console.WriteLine(val);
Console.WriteLine(myInt1);


/* Type Conversion (Convert class)
Take user input as a string, convert it to int using Convert.ToInt32(), 
and print it doubled. */

Console.WriteLine("Enter the value: ");
int num = Convert.ToInt32(Console.ReadLine());

int doubledVal = num * 2;
Console.WriteLine(doubledVal); 