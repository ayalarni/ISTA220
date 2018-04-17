C#Chapter7,Pages153-174

##Norma I. Ayala-Rosa

1. What is a class? A class is the root word of the term classification.  A group of collective ideas.
What does a class arrange? A class arranges information (common attributes) and behavior into meaninful entities.

2. What are the two purposes of encapsulation? One purpose is to combine methods and data within a class; to support classification.
The other purpose is to control the accessibility of the methods and data, to control the use of the class.

3. How do you instantiate an instance of a class? To define it.
How do you access that instance? Class Object = new Class

4. What is the default access of the fields and the methods of a class? It is private.
How do you change the default? Change it by change the access modifier.

5. What is the syntax for writing a constructor? Use the same name as a class.
The constructor only has the method name and the same parameters with no return type.

6. What is the difference between class fields and methods, and instance fields and methods? The fields and methods can inherit but no viceversa.  Fields store data that any method or class in the program can access.

How do you create class fields and methods?  Instanced fields and methods store data until the variables are out of scope.

7. How do you bring a static class in scope? Name the class and access it with static.
Why would you want to bring static class in scope? To keep it the same.

8. Can you think of a good reason to create an anonymous class? When you want to keep it private. i. e. client and server side.
What is it? An anonymous class is a class that does not have a name.

9. What is a polymorphism as this term is used in computer science? It is different versions of the same.

10. What is message passing as this term is used in computer science? The type of communication between processes.

11. What is the first-object oriented programming language? LISP

12. Consider this quote by Alexander Stepanov:
I found OOP technically unsound. It attemps to decompose the world in term of interfaces
that vary on a single type.  To deal with the real problems you need multisource algebras
--families of interfaces that spam multiple types. I found OOP pilosophically unsound. It
claims that everything is an object.  Even if it is true it is not very interesting -- saying
that everything is an object is saying nothing at all.

Who is Alexander Stepanov? A Russian computer programmer born November 16, 1950 in Moscow, best known as an advocate of generic programming and as the primary designer and implementer of the C++ Standard Template Library, which he started to develop around 1992 while employed at HP Labs. He had earlier been working for Bell Labs close to Andrew Koenig and tried to convince Bjarne Stroustrup to introduce something like Ada generics in C++. He is credited with the notion of concept.

What do you think about this quote? He has a point, everything is not an object!