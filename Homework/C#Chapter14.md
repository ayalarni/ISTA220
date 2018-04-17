#C#Chapter14Pages305-328

##Norma I. Ayala-Rosaby 

1. What is the difference between a managed resource and an unmanaged resource? A managed resource is handled by CLR (a virtual machine)
an the unmanaged resource can be manipulated by the programmer (don't carry CLR resources). 

2. When is memory for an object (reference type) allocated? When new is used.
When is the memory deallocated? When the referece counts is 0, it dissapears.

3. What is a destructor? A destructor is a special method, a little like a constructor, except that the Common Language Runtime (CLR) calls it after the reference to an object has dissapeared. You can't call a destructor.  Only the garbage collector can call a destructor. It reclaims the memory.

4. What is the difference in syntax between a constructor and a destructor? The syntax for writing a destructor is a tilde (~) followed by the name of the class. 

5. Give some examples of scarce resources. These are memory, database connections, and file handles needing releasing. 
Why would you want to manage scarce resources? 

6. What is exception-safe disposal? It is a way to get rid of the garbage.  The file handler won't be closed.

7. How do you think that the using statement works for resource management? Uses all the resources inside.
using ( type variable = initialization )
{
  StatementBlock
}

8. What ill effects could result from attempting to dispose from a resource more than once? 
Nothing bad happens.

9. What is your understanding how threads interact with resource management? 

10. Why does the book recommend not attempting to force the garbage collector? Humans beings may not understand what is happening!
Are there any exceptions to this recommendation? 