#C#Chapter11Pages243-254

##Norma I. Ayala-Rosa

1. How do you define a method that takes an arbitrary number of arguments?
Use the Params keyword. 

2. How do you call a method that takes an arbitrary number of arguments?
someType Method(params object[] paramList)
{
  ...
}

It is as easy as following up, use it!

3. Why can't you use an array to pass an arbitrary number of arguments to a method?
You can!

4. How many parameters can a method have? 
A method takes a certain number of parameters.

5. Do parameters arguments have to have the same type? No.

6. What is the difference between a method that takes a parameter argument and one that takes optional arguments?
You have to have a specific number of parameters, on an optional, you are limited.
For an optional parameter, give it a default value.

7. How do you define a method that takes different (and arbitrary) types of arguments? 
Change the type to OBJECT.

