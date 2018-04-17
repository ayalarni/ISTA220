#C#Chapter9, Pages201-219

##Norma I. Ayala-Rosa


1. Declare an enum for military ranks, either officer or enlisted. 

enum MilitaryRanks { Officer, Enlisted }  

Name its ranks.

enum MilitaryRanks { 2LT, 1LT, CPT, MAJ, LTC, COL }

What are the symbols Private, Corporal, 1LT, 2LT, CPT.

2. Using the ranks enum, assign a rank to your or a friend.

enum MilitaryRank { LieutenantColonel }

3. Determine a numeric index of particular ranks, using the ranks enum.


4. How do you select the type of an enum? When declaring it, the enumeration literals are given values of type int (integer), or a short to save memory, or a byte, sbyte, ushort, uint, long, ulong.

5. Are strucks stored on the stack or on the heap? Strucks are stored on the stack, it is a value type.
What about enums?


6. Declare a struct named DOD with four branches.

struct DOD
{
    public string Army, Navy, Air Force, Marines;
} 

7. Why can't you create a default constructor for a struct? The compiler always generates one. The compiler-generated default for a struc always sets the fields to 0, false, or null--just as for a class.

8. What is Common Intermediate Language (CIL)? When compiling C# application, the compiler converts the C# code into a set of instructions using a pseudo-machine code the CIL.  These are the instructions that are stored in an assembly.

What does the Common Language Runtime (CLR) do to the CIL? When C# application is running, the CLR takes responsibility for converting the CIL instructions into real machine instructions that the processor on your computer can understand and execute. 