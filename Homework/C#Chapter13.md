#C#Chapter13Pages277-293

##Norma I. Ayala-Rosa

1. What is an interface as the term is used on object-oriented programming? It is a shared boundary across which two or more separate components of a computer system exchange information. An interface does not contain any code or data; it just specifies the methods and properties that a class that inherits from the interface must provide.

2. How do you define an interface? It is syntactically similar to defining a class, except that you use the interface keyword instead of the class keyword.  The methods in an interface have no implementation.  Enclosed a parameter, name and a return.

3. Can an interface have variables, fields, or properties? No, an interface cannot contain any data; you cannot add fields (not even private ones) to an interface.

4. How do you define a method on an interface? All methods implementing an interface must be publicly accesible. However, if you
are using an explicit interface implementation, the method shoud not have an access qualifier.  You replace the method body with a semicolon.

interface IComparable
{
 int CompareTo(object obj);
}

5. Can you instantiate an object through an interface? Yes, referencing an object through an interface is useful because you can
use it to define methods that can take different types as parameters, as long as the types implement a specified interface.
Why or why not? Remove the dependency.  

6. Using the new keyword, can you declare a reference through an interface? Yes.

7. Can an object inherit from multiple interfaces?  
It is allowed to implement an unlimited number of interfaces.
Can a class implement multiple interfaces? A class must implement all the methods declared by these interfaces.
If so, how can it do so? 

8. What does it mean to explicitly implement an interface? C# does not distinguish which interface the method is implementing, so the same
method actually implements both interfaces; i.e. specify which interface a method belongs to when you implement it.  Class Horse, the horse has four legs and has pulled the coach for three legs of the journey.

9.  What are the restrictions on interfaces? 
- You are not allowed to define any fields in an interface, not even static fields.  A field is an implementation detail of a class
or structure.
- You are not allowed to define any constructors in an interface. A constructor is also considered to be an impelemntation detail of a class or structure.
- You are not allowed to define a destructor in an interface. A destructor contains the statements used to destroy an object instance.
- You cannot specify an access modifier for any method. All methods in an interface are implicitly public.
- You cannot nest any types (enumerations, structures, classes, interfaces) inside an interface.
- An interface is not allow to inherit from a structure or a class.

10. What is the difference between an abstract class and an interface? An abstract class can cointain abstract methods. 

11. What is an abstract method? An abstract method cannot be private. It is useful if it does not make sense to provide a default imlementation in the abstract class but you want to ensure that an inheriting class provides its own implementation of that method.

12. What is a sealed class? A sealed class cannot declare any virtual methods and that an abstract class cannot be sealed, because you cannot inheret from it.

13. What is a sealed method? It is the last implementation of a method, a derive class cannot override this method.