# C#Chapter5
## Pages 107 - 125

### Norma I. Ayala-Rosa


1. What is a compound assignment operator?
It shares the same precedence and right associativity as the simple assignment operator (=).

How does it work?
If you want to add 42 to the value of a variable, you can combine the assignment operator and the
plus operator.

2. List all the compound assignment operators?
variable *= number;
variable /= number;
variable %= number;
variable += number;
variable -= number;

3. List two ways to increment a numeric value by 5?
count += 5;
count = count+ 5;

List two ways to decrement a numeric value by 50.
count -= 50;
count -- 50;

4. How long does a while loop run?
Use it to run a statement repeatedly for as long as some condition is true.

5. What happens if you don't change the loop variable in the body of the while loop block?
Only the first statement that immediately follows the Boolean expression in the while construct will be executed
as part of the loop, resulting in difficult-to-spot bugs.  The code iterates forever, displaying an infinite
number of zeros.

6. How many parts does a for loop statement have?
It has three parts; initialization, a test, and update control variable.
They must always be separated by semicolons, even when they are omitted. 

Can you omit any of them?
Yes, you can omit any of the three parts of a for statement.

Can you omit all of them?
No.  What happens if you omit all of them?  If you omit the Boolean expression, it defaults to true, so the for statement runs forever.

7. How do you guarantee that a loop runs at least once?
A do while loop.

8. What does a break statement do?
It can be used to jump out of the body of an iteration statement, in addition to jump out of a switch statement.  It brings it to a stop!

9. What does a continue statement do?
It keeps the rest!  A continue statement, if executed from within a for statement, the update part runs before performing the next iteration of the loop.