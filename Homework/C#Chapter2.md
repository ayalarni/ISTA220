C#Chapter2

Norma I. Ayala-Rosa

1. What is a local variable?
It is visible inside a block of code.

2. What is a statement?
Is a command that perform an action, such as calculating a value and storing the result or displaying a message to a user.  One combines statements to create methods.  In C# 
it ends with a semicolon.

3. What is an identifier?
Identifiers are the names that you use to identify the elements in your programs, such as namespaces, classes, methods, and variables.  It cannot start with a digit.

4.  What is a variable?
A variable is a storage location that holds a value. A variable is a box in the computer’s memory holding temporary information. A name location and memory that contains a value.

5. What is a method?
A method is a named sequence of statements.  It is a name, location and memory that reference a behavior.

6. Are primitive types and value types the same thing?
A primitive types and values types are the same if it can fit in a byte location.  

7.  How are arithmetic operators and variable types related?
It depends on the value’s type.  An operator represented by a plus sign…

8. How do you turn an integer into a string?
Use the Tostring method.

9. How do you turn a string into an integer?
Use the ToInt32 method.

10. What is the difference between precedence and associativity? Give an example where this makes a difference.
Precedence it relates to different operators and associativity refers to same level of precedence; how normally operators act.

11. What is the definite assignment rule?
One must assign a value to a variable before one can use it; otherwise the program won’t compile.

12. How are the prefix and the postfix increment and decrement operators evaluated differently?  Whether one use the prefix or postfix form of the ++ or – operator makes no difference to the variable being incremented or decremented.

13. What is string interpolation?
String interpolation is more efficient than using the + operator.  It is also more readable and less error prone.  Such as the $ symbol at the start of the string indicates that it is an interpolated string and that any expressions between the (and) characters should be evaluated and the result substituted in their place.

14. What does the var keyword do?
It causes the compiler to deduce the type of the variables for the types of the expressions used to initialize them.
