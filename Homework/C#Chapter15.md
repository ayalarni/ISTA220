#C#Chapter15Pages329-352

##Norma I. Ayala-Rosa

1. What is the difference between a property and a field? A property is a cross between a field and a method--it looks like a field but acts like a method. A field is plain verbal, a property have behavior.

2. What is the difference between a property and a method? A method don't have data, a property do.

3. What is your understanding of encapsulation? It modularizes functionality.

4. Some languages are case insensitive, that is, an `a" and an \A" are considered to be the same letter.
C# is case sensitive. What implications does this have regarding the naming of variables, methods,
and other identifiers? Identifiers that start with an uppercase letter for publicly accessible methods and fields, and
use identifiers that start with a lowercase letter for private methods and fields. 

Do you think that the difference in case in the initial character of two different identifiers is sufficient to distinguish them?

5. Give an example that is not in the book of an instance where you might want to use a read-only
property. It has a get only.

Give an example not in the book of an instance where you might want to use s write-only
property. 

6. Can you think of a reason why you might ever want to make getters and setters private? Give an
example. To allow users to use it without the functionality.
Also, make a case why getters and setters should never be private. 

7. What are restrictions on the use of properties? 
You can change the accesibility of only on eof the accessors when defined.
The modifier must not specify

8. What is an object initializer? The compiler generates code that calls the default constructor and then calls the set accessor of each named property to initialize it with the value specified.
What is the syntax for an object initializer?
{
   public int NumSides {get: set; }
   public double SideLenght { get; set; }
}