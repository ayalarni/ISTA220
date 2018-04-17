#CChapter10,Pages221-242

##Norma I. Ayala-Rosa

1. What does an array look like in memory? A contiguous block of memory accessed by using an index.
Var [0]  1001  1
Var [1]  1002  2
Var [2]  1003  3
       .
       .

2. Where is memory allocated to hold an array, on the stack or on the heap?  An array variable refers to a contiguos block of memory
holding the array elements on the heap.  On the stack is memory address or reference.

3. Where is memory allocated to hold an array reference,on the stack or on the heap? Even if the array contains a value type such as int, the memory will still be allocated on the stack.

4. Can an array hold values of different types? Yes. All the values or elements has to be of the same type, because how memory is allocated. 

5. Describe the syntax of the condition or a foreach loop. The foreach loop in C# executes a block of code on each element in an array or a collection of items.

6. How do you make a deep copy of an array? If we want to create a copy of arr1; we can't just give it another pointer; we have to create a new array and fill it with the contents of the first array. This is quite the object. Any sub-arrays or sub-objects (or sub-sub-sub-objects) will be treated in the same manner, hence why it's called a “deep copy”.

7. What is the difference between a multi-dimensional array and an array of arrays?

Multi [ , ]

Array of arrays [ ] [ ]

8. How do you flatten a multidimensional array? In other words take something that looks like a matrix
and turn it into an array. 

For ( int i = 0; i<3; i++ )
For (int j = 0; j<3; j++)