using System;

string name = "Hakimxon", job = "Tarmoq administratori";
int age = 32, staj = 8;

System.Console.WriteLine($"Mening ismim: {name} \nYoshim: {age} da");
System.Console.WriteLine($"Kasbim: {job}, \nTajribam: {staj} yil");

string yourName, yourAge;

System.Console.Write("Ismingizni kiriting: ");
yourName =  System.Console.ReadLine();

System.Console.Write("Yoshingizni kiriting: ");
yourAge = System.Console.ReadLine();

System.Console.WriteLine();
System.Console.WriteLine($"Assalomu alaykum {yourName}");
System.Console.WriteLine($"siz {yourAge} yoshdasiz");
System.Console.WriteLine($"Siz bilan tanishganimdan hursandman!");