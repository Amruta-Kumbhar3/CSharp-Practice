/* Question 1: Math.Max and Math.Min
Declare two int variables. Print the larger one using Math.Max() 
and the smaller one using Math.Min(). */

int a = 30, b = 20;

int resultMax = Math.Max(a,b);
Console.WriteLine(resultMax);

int resultMin = Math.Min(a,b);
Console.WriteLine(resultMin);


/* Question 2: Math.Sqrt
Declare a number and print its square root using Math.Sqrt(). */
double resultSqr = Math.Sqrt(a);
Console.WriteLine(resultSqr);



/* Question 3: Math.Abs
Declare a negative number and print its absolute value using Math.Abs(). */
int c = -3;
int resultAbs = Math.Abs(c);
Console.WriteLine(resultAbs);


/* Question 4: Math.Round
Declare double price = 14.567;. Round it to 2 decimal places using Math.Round(). */
double price = 14.567;
double roundFigure = Math.Round(price,2);
Console.WriteLine(roundFigure);

/* Question 5: Concatenation
Declare a string first name and a string last name. Combine them with + 
into one full name (with a space between them) and print it. */
string name = "Amruta", lastName = "Kumbhar";
Console.WriteLine("Full name is: "+name+" "+lastName);


/* Question 6: String Interpolation
Redo Question 5 using interpolation ($"...") instead of +. */
string name1 = "Amruta", lastName1 = "Kumbhar";
string fullName = $"Full name is: {name1} {lastName1}";
Console.WriteLine(fullName);


/* Question 7: Interpolation with Math
Declare int num1 and int num2. Print their sum using interpolation, 
doing the addition directly inside the curly braces. */
int num1 = 10, num2 = 20;
Console.WriteLine($"Sum of num1 and num2 is: {num1 + num2}");


/* Question 8: Access Strings (indexing)
Declare string word = "Amruta";. Print the first character using word[0], 
then print the last character using word[word.Length - 1]. */
string word = "Amruta";
Console.WriteLine(word[0]);
Console.WriteLine(word[word.Length-1]);


/* Question 9: Access Strings (Substring)
Using the same word variable, print the last character again, this time 
using word.Substring(word.Length - 1) instead of []. */
string lastchar = word.Substring(word.Length-1);
Console.WriteLine(lastchar);


/* Question 10: Special Characters
Print a sentence that includes double quotes inside it (using \"), 
and a sentence that prints across two lines using \n. */
string txt = "My name is \"Amruta\". and i am from India \nbut living in malaysia from last 2 years.";
Console.WriteLine(txt);


/* Question 11: Special Characters (backslash)
Print a fake file path like C:\Users\Amruta using \\ for each backslash. */
string filePath = "c:\\Users\\Amruta\\0.1Png";
Console.WriteLine(filePath);


/* Question 12: Combined
Take a user's first name and last name as input, convert their age 
(also user input) to int, and print a full sentence using interpolation 
that includes their name, age, and next year's age (age + 1). */
Console.WriteLine("Enter your first name: ");
string userName = Console.ReadLine();

Console.WriteLine("Enter your last name: ");
string userLastName = Console.ReadLine();

Console.WriteLine("Enter your current age: ");
int userAge = Convert.ToInt32(Console.ReadLine());
int nextYrAge = (userAge + 1);

string userDetails = $"full name: {userName} {userLastName}\ncurrent age: {userAge}\nnext year you will be {nextYrAge} year old.";
Console.WriteLine(userDetails);