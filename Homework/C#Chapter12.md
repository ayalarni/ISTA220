#C#Chapter12Pages255-276

##Norma I. Ayala-Rosa

1. How does inheritance promotes the principle of don't repeat yourself (DRY)? By using class inheritance, so one does not have to write the same functionality or method again.  Encapsulate the functionality to call it.

2. What is the syntax of a derived class that inherits from a base class? DerivedClass : BaseClass

3. Do all users define type (classes and structs) inherit from some base class? If so, what is it? Yes, Inheritance applies only to classes, not to structs.

4. What happens if you don't have a default constructor in a base class when creating a derived class? If you don't explicitly call a base class constructor , the complier attempts to silently insert a call to the base class's default constructor before executing the code in the derived class constructor.

5. Can you assign a variable of a derived class to another variable of a derived class of its base class? Why or why not?
It is possible to refer to an object from a variable of a different type as long as the type used is a class that is higher up the inheritance hierarchy.

6. Can you assign a variable of a derived class to another variable of a derived class of its base class?  Why or why not?
It depends.

7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?
It depends.

8. Under what circumstances would you want to use the new key word when defining a method in a derived class?
When two methods have the same parameters, i.e. swim or horse may do something different.

9. What is a virtual method? A method that is available to be overriden.
Why would you want to define a virtual method? It is a mechanism for providing different implementations of the same method.

10. What does override do?  The methods are all related because they are intended to perform the same task.
Why does it do it? It is a useful programming concept.

11. How do you define an extension type? Define an extension method in a static class and specify the type to which the method applies as
the first parameter to the method.  static (this int)

12. Why do you define an extension type? To add a functionality.