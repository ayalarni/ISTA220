using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions1
{
    class Areas
    {
        static void Main(string[] args)
        {
            
            checked
            {
                
                float circum;
                float pi = 3.14159F;

                MainMenu();

                
                void MainMenu()
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Enter the formula you want to use:\n\n" +
                        "1) Circumference of a circle\n" +
                        "2) Area of a circle\n" +
                        "3) Hemisphere of a circle \n" +
                        "4) Area of a triangle\n" +
                        "5) Quadratic Formula \n" +
                        "6) Exit\n");

                        int menuChoice = int.Parse(Console.ReadLine());

                        switch (menuChoice)
                        {
                            case 1:
                                Circumference();
                                break;
                            case 2:
                                CircleArea();
                                break;
                            case 3:
                                Hemisphere();
                                break;
                            case 4:
                                TriArea();
                                break;
                            case 5:
                                Quadratic();
                                break;
                            case 6:
                                return;
                            default:
                                Console.WriteLine("Not a valid choice, press enter and try again...");
                                Console.ReadLine();
                                MainMenu();
                                break;
                        }

                    }
                    
                    catch (FormatException fEx)
                    {
                        Console.WriteLine(fEx.Message);
                        Console.ReadLine();
                        MainMenu();
                    }
                   
                    catch (OverflowException ofEx)
                    {
                        Console.WriteLine(ofEx.Message);
                        Console.ReadLine();
                        MainMenu();
                    }
                    
                    catch (DivideByZeroException dbzEx)
                    {
                        Console.WriteLine(dbzEx.Message);
                        Console.ReadLine();
                        MainMenu();
                    }

                }

                
                void Circumference()
                {
                    
                    Console.Clear();
                    Console.WriteLine("enter a value for the radius");
                    float r = float.Parse(Console.ReadLine());

                   
                    while (r <= 0)
                    {
                        Console.Write("The radius must be a positive number, try again\n" +
                            "enter a value for the radius: ");
                        r = float.Parse(Console.ReadLine());
                    }
                    circum = 2 * pi * r;
                    Console.WriteLine($"The circumference of the circle is {circum}\n" +
                        $"Press <enter> to continue...");
                    Console.ReadLine();
                    MainMenu();
                }

                
                void CircleArea()
                {
                    Console.Clear();
                    Console.WriteLine("enter a value for the radius");
                    float r = float.Parse(Console.ReadLine());

                    
                    while (r <= 0)
                    {
                        Console.WriteLine("The radius must be a positive number\n" +
                            "enter another value:");
                        r = float.Parse(Console.ReadLine());
                    }
                    float area = pi * (r * r);
                    Console.WriteLine($"The area of the circle is {area}\n" +
                        $"Press <enter> to continue...");
                    Console.ReadLine();
                    MainMenu();
                }

               
                void Hemisphere()
                {
                    Console.Clear();
                    float vol;
                    Console.WriteLine("Enter a radius value");
                    float r = float.Parse(Console.ReadLine());

                   
                    while (r <= 0)
                    {
                        Console.WriteLine("The radius must be a positive number\n" +
                            "enter another radius value:");
                        r = float.Parse(Console.ReadLine());
                    }
                    vol = ((4 / 3) * pi * (r * r * r)) / 2;
                    Console.WriteLine($"The volume of the circle is {vol}\n" +
                        $"Press <enter> to continue...");
                    Console.ReadLine();
                    MainMenu();
                }

                
                void TriArea()
                {
                    
                    Console.Clear();
                    Console.WriteLine("Enter a value for the first side");
                    int sideA = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a value for the second side");
                    int sideB = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a value for the third side");
                    int sideC = int.Parse(Console.ReadLine());

                    
                    if ((sideC <= 0) || (sideB <= 0) || (sideC <= 0))
                    {
                        Console.WriteLine("The value of the side must be greater than zero");
                        Console.ReadKey();
                        goto START;
                    }

                    double p = (sideA + sideB + sideC) / 2;
                    double areaFinal = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideB));

                    Console.WriteLine($"The area of the tringle is {areaFinal}\n" +
                        $"Press <enter> to continue...");
                   
                    Console.ReadLine();
                    MainMenu();
                }

                
                void Quadratic()
                {
                    
                    START:
                    float coA = -1, coB = -1, coC = -1;
                    
                    bool sqrtCheck = true;

                    Console.Clear();
                    Console.WriteLine("Using the formula ax^2 + bx +c\n" +
                        "enter the coefficient for 'a'");
                    coA = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the coefficient for 'b'");
                    coB = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the coefficient for 'c'");
                    coC = float.Parse(Console.ReadLine());

                    sqrtCheck = double.IsNaN(Math.Sqrt(coB * coB - 4 * coA * coC));

                    
                    if (sqrtCheck == true)
                    {
                        Console.WriteLine("The square root contains a negative value which is not allowed\n" +
                            "press enter to enter values again");
                        Console.ReadLine();
                        goto START;
                    }

                    double x1 = (-coB + Math.Sqrt(coB * coB - 4 * coA * coC)) / (2 * coA);
                    double x2 = (-coB - Math.Sqrt(coB * coB - 4 * coA * coC)) / (2 * coA);

                   
                    if ((double.IsNaN(x1)) || (double.IsNaN(x2)))
                    {
                        Console.WriteLine("The value of x is not a real number\n" +
                            "press enter to enter values again");
                        Console.ReadKey();
                        goto START;
                    }

                   
                    if ((double.IsInfinity(x1)) || (double.IsInfinity(x2)))
                    {
                        Console.WriteLine("The value of x is infinity\n" +
                            "press enter to enter values again");
                        Console.ReadKey();
                        goto START;
                    }

                    Console.WriteLine($" x = ({x1},{x2})\n" +
                        $"Press <enter> to continue...)");
                    Console.ReadLine();
                    MainMenu();
                }
            }
        }
    }
}