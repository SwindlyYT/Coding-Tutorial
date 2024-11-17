

// Same namespaces are connected
namespace Project
{
    // Class 
    internal class Program
    {
        // Always runs
        static void Main(string[] args)
        {
            // Declaring a string variable called str with no value
            string str;

            // Write lines
            Console.WriteLine("Hello, World!");

            // Read input from the console (\n which is new line which is enter key)
            Console.ReadLine();

            // Reads line from console and puts it into a string variable. 
            str = Console.ReadLine(); // This warning doesnt mean much we arent doing proper error handling which will done later on

            // Will write the line typed from the console and write it back out
            Console.WriteLine(str + "\n");

            // Read the input from the console and then it will print to the console. Inner most functions get called FIRST
            Console.WriteLine(Console.ReadLine());

            Console.ReadLine();
        }
    }
}