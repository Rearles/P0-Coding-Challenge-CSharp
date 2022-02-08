using P0_Coding_Challenge_CSharp;



Reverse reverse = new Reverse();
string test1 = "Happy Birthday";
string test2 = "MANY THANKS";
string test3 = "sPoNtAnEoUs";

Console.WriteLine("");
Console.WriteLine("Test 1: ");
Console.WriteLine("Original String: " + test1);
Console.WriteLine("Case Reversed String: " + reverse.ReverseCase(test1));

Console.WriteLine("");
Console.WriteLine("Test 2: ");
Console.WriteLine("Original String: " + test2);
Console.WriteLine("Case Reversed String: " + reverse.ReverseCase(test2));

Console.WriteLine("");
Console.WriteLine("Test 3: ");
Console.WriteLine("Original String: " + test3);
Console.WriteLine("Case Reversed String: " + reverse.ReverseCase(test3));