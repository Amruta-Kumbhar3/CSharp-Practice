//Arithmetic Operators

/*Declare two int variables. Print the result of +, -, *, /, and % between them.*/

int a = 10, b = 5;
int add = a+b;
int sub = a-b;
int mul = a*b;
double div = (double)a/b;
int mod = a%b;

Console.WriteLine("addition of a & b is: "+add);
Console.WriteLine("substraction of a & b is: "+sub);
Console.WriteLine("multiplication of a & b: "+mul);
Console.WriteLine("division of a & b is: "+div);
Console.WriteLine("mode of a & b is: "+mod);

/*Fix the division issue on purpose: show both the "wrong" way (int / int, loses decimal)
and the "correct" way (casting one side to double first) side by side, so the file 
demonstrates you understand the difference.*/
int a1 = 10, b1 = 7;
int div1 = a1/b1;
double mydiv = div1;
Console.WriteLine("div with int is: "+div1);
Console.WriteLine("div after typecasting: "+mydiv);

//Assignment Operators
/*Declare int total = 50;. Apply +=, -=, *=, and /= one after another (each 
on the updated value from the previous step), printing total after each operation.*/
int total = 50;
total += 10;
Console.WriteLine(total);
total -= 8;
Console.WriteLine(total);
total *= 10;
Console.WriteLine(total);
total /= 5;
Console.WriteLine(total);

//Comparison Operators
/*Declare two double variables with different values. Print the result of all six 
comparison operators (==, !=, >, <, >=, <=) between them.*/
double num1 = 8, num2 = 4;
Console.WriteLine(num1 == num2);
Console.WriteLine(num1 != num2);
Console.WriteLine(num1 > num2);
Console.WriteLine(num1 < num2);
Console.WriteLine(num1 >= num2);
Console.WriteLine(num1 <= num2);

//Logical Operators
/*Declare two bool variables. Print the result of &&, ||, 
and ! on them (use ! on just one of the two).*/
bool isActive = true, isNotActive =false;
Console.WriteLine(isActive && isNotActive);
Console.WriteLine(isActive || isNotActive);
Console.WriteLine(!isNotActive);

/*Combine a comparison and a logical operator in one line: 
declare an int age and a bool hasID, and print whether (age >= 18) && hasID is true.*/
int age = 27; bool hasID = true;
if (age >= 18 && hasID)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}

//Combined/Applied
/*Take two numbers as user input, convert them to int, and print the result of all five 
arithmetic operators between them (reuse the casting trick from question 2 for 
accurate division).*/
Console.WriteLine("enter value for number1 = ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter value for number2 = ");
int numb2 = Convert.ToInt32(Console.ReadLine());

int add1 = numb1 + numb2;
Console.WriteLine(add1);

int sub1 = numb1 - numb2;
Console.WriteLine(sub1);

int mul1 = numb1 * numb2;
Console.WriteLine(mul1);

double divi1 = (double)numb1 / numb2; 
Console.WriteLine(divi1);

int mod1 = numb1 % numb2;
Console.WriteLine(mod1);

