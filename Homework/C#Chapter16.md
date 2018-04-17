#C#Chapter16Pages353-368

##Norma I. Ayala-Rosa

1. Give five examples (using valid C# code) of the five bitwise operators listed in the text.
 1) The NOT (~) operator - 
 2) The left-shift (<<) operator
 3) The OR (|) operator - 1 | 0=1
 4) The AND (&) operator
 5) The XOR (^) operator

2. Does C# implement the right-shift (>>) operator? Yes.
If so, give an example of its operation using value C# code. 

3. Explain in detail this code: bits & (1 << index); uses the left-shift operator and bitwise AND operators to determine whether the () bit from the right of the byte variable named bits is set to () or ().

4. Explain in detail this code: bits |= (1 << index); uses the left-shift operator and bitwise OR operators to determine whether the () bit 
 
5. Explain in detail this code: bits &= (1 << index); 

6. How does C# interpret this? bool peek = bits[n];
 
7. How does C# interpret this? bits[n] = true;

8. How does C# interpret this? bits[n] ^= true;

9. Assume that users were assigned read, write, and execute permissions according to this scheme: read
= 1, write = 2, execute = 4. How would you interpret the following user permissions:
(a) permission = 0 no permission
(b) permission = 1 read
(c) permission = 2 write
(d) permission = 3 r + w
(e) permission = 4 execute
(f) permission = 5 e + r
(g) permission = 6 e + w
(h) permission = 7 e + w + r

10. Answer the previous question by converting the decimal permissions into binary permissions. What does this tell you about using this scheme of permissions?
