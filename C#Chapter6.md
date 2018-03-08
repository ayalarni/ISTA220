# C#Chapter6
## Pages 127-150

### Norma I. Ayala-Rosa


1. What is an exception?
It is an error.  An exception is NOT always an error.

2. What happens in a try block if the program executes without errors?
If none of the statements generate an exception, they all run, one after the other to completion.

3. How does the catch mechanism work for unhandled exceptions?
A catch handler is intended to capture and handle a specific type of exception.  The runtime
then examines the catch handlers after the try block and transfers control directly to the first matching handler.

4. What happens in a program if an exception block fails to handle a particular error?
It terminates and gives an error message.

5. What is the parent class for all exceptions?  How does this work?
It is a system exception.  

6. How do you determine the type of an error?
Using exception filters.

7. What is the purpose of an integer checking?
If you have a number, signed or unsigned integer; to prevent overflow and get the wrong answer.

8. What does the finally block do?
It makes sure that a statement always run and to close a handler.
A finally block occurs immediately after a try block or immediately after the last catch handler after a try block.