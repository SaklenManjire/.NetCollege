namespace DayOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Experiment 1 Arithmatic opertaion
           /* int a = 10;
            int b = 20;
            int choice;
            do
            {
                Console.WriteLine("1.Add\n2.Sub\n3.Mul\n4.Div");
                Console.WriteLine("Enter your choice:");
               choice= Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition of a and b:"+(a+b)) ;
                        break;
                    case 2:
                        Console.WriteLine("Subtraction of a and b:" + (a - b));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication of a and b:"+ (a * b));
                        break;
                    case 4:
                        Console.WriteLine("Division of a and b:"+(a / b));
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice!=0);
*/

            //Find factorial
            Console.WriteLine("Enter value of n:");
            int n=Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact*= i;
             
            }
            Console.WriteLine($"Factorial of number {n} is:"+fact);

            //sum of array
            Console.WriteLine("Enter array size:");
            int size=Convert.ToInt32(Console.ReadLine());
            int [] array=new int[size];
            var sum = 0;


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter value {i+1}");
                array[i]=Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                sum +=array[i];
    
            }
            Console.WriteLine($"Sum of array number is {sum}");



        }
    }


   
  
}
