// this an introduction to array class in C#

int[] A = new int[10] { 10, 4, 5, 6, 22, 3, 7, 8, 9, 10,12,15 };
string[] B = { "GTC", "Book", "Cat", "X", "Door" };

double avg = A.Average();

int sum = A.Sum();
int min = A.Min();

int max = A.Max();


Console.WriteLine("SUM = {0:F}", sum);
Console.WriteLine("Average = {0:F}", avg);
Console.WriteLine("Min = {0:F}", min);
Console.WriteLine("MAx = {0:F}", max);

Console.Write("Enter value to search:");
int x = Convert.ToInt32(Console.ReadLine());

bool isexists = A.Contains(x);
Console.WriteLine(" the search result is {0}", isexists);

int pos = Array.IndexOf(A, x);
Console.WriteLine(" the {0} found in  {1} position", x, pos);


B.Reverse();
Array.Sort(B);


Console.WriteLine();
foreach (string item in B)
    Console.WriteLine(item);

Console.ReadKey();
