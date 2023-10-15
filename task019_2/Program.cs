Console.Clear();

System.Console.WriteLine("Enter Number: ");
int N = Convert.ToInt32(Console.ReadLine());
int revN = 0;
for (int i = N; i > 0; i/=10)
{
    revN =  revN * 10 + i % 10;
    //System.Console.WriteLine(revN);
}
if(N == revN)
System.Console.WriteLine("Yes");
else 
System.Console.WriteLine("No");