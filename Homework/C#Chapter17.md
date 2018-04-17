C#Chapter17Pages369-398

##Norma I. Ayala-Rosa

1. What is a type parameter? It specify the types of objects on which they operate.  In C# you indicate that a class is a generic class by providing a type parameter in angle brackets, <T> It is a place holder.

2. What does a type parameter do? When the compiler sees it, creates a brand new type for the class.

3. How many type parameters can a generic class have? It can have multiple type parameters. One type for keys and another for values.

4. What is the difference between a generic class and a generalized class?
A generalized class is designed to take parameters that can be cast to different types. Can take a parameter of type object.
A generic class uses type parameters.  It specializes on a type object.

5. What is a constraint? A constraint can limit the type parameters of a generic class to those that implement a particular set of
interfaces and therefore provide the methods defined by those intefraces.
How do you specify a constraint?

6. What is a generic method? You can specify the types of the parameters and the return type by using a type parameter in a manner similar to that used when you define a generic class.
How do you define a generic method? Use the same type parameter syntax you use when you create generic classes. 

7. What do we mean when we say that a generic type interface is invariant? 

8. What do we mean when we cay that a generic type interface is covariant?

9. Does covariance work with value types? Does it work with reference types?

10. What do we mean when we say that a generic type interface is contravariant? If methods in a generic interface can take object parameters, they can take string parameters.  
