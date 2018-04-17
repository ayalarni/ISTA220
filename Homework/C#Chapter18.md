C#Chapter18Pages399-422

##Norma I. Ayala-Rosa

1. You are building a help ticket system. You want to ensure that the older the ticket, the sooner it will be handled by the team. For example, a ticket submitted a week ago has a higher priority than a ticked just submitted. What kind of data structure would you use, and why?  Queue - A first-in, first-out data structure, an element is inserted into the queue at the back and is removed from the queue at the front.

2. You are building a tracking system for seasonal agricultural farm labor. The labor requirements vary widely, depending on the season. Your requirement is that the newest hires are terminated first, and that our more experienced hires are kept longer. What kind of data structure would you use, and why? Stack - A last-in, first-out data structure, similar to the stack of dishes (new dishes are added to the top and dishes are removed from the top).

3. You are building a transaction database. Your requirement is that the database adds data very quickly, and that deletions, updates, and searches happen infrequently. In other words, data is typically added in the order in which the transaction occurs. What kind of data structure would you use, and why? List<T>

Hashset<T>, an unordered set of values optimized for fast retrieval of data or performing set operations.

4. You are building an analytical database. Your requirement is that the database handle queries very quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates. What kind of data structure would you use, and why?
SortedList or Dictionary<TKey, TValue>

5. You are building a personnel directory, where searched are performed by last name, first name, middle name. What kind of data structure would you use, and why? SortedList<TKey, TValue> or Dictionary<TKey, TValue>

6. You are building a username/password database. Your requirement is that updates happen frequently (when users change their passwords) and that searches (to authenticate users) happen extremely quickly. What kind of data structure would you use, and why? Linkedlist<T>

7. What is a lambda expression? Give an example. An anonymous method, it provides a notation for describing functions (a method that returns a value).
Why would we use a lambda expression?

8. What is the difference between lambda expressions and anonymous methods? Lambda expressions provide a more succinct and natural syntax than anonymous methods, and they pervade many of the more advanced aspects of C#.
What are the advantages of each? Use lambda expressions rather than anonymous methods in code.  Anonymous methods can perform a similar task but are not as flexible, they were added primarily so that you can define delegates without having to create a named method.
