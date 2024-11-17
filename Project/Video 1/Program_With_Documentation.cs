
// Same as Program.cs except namespace is different (cant have same name classes and methods in the same namespace) and this one is more
// heavily commented


// Namespace of this script. Can be anything. Same namespaces are connected to one another
namespace VideoOne
{
    // Class. Thats about it for now
    internal class Program
    {
        // Main method. This will run at the start of the program
        static void Main(string[] args)
        {
            // Declares a string variable called str that is not assigned a value
            string str;

            // This line prints to the console
            Console.WriteLine("Hello, World!");

            // Reads input from the console. Captures everything until the user presses enter
            Console.ReadLine(); // (\n is what it appears as in code)

            // Reads input from console and puts it into a string variable to be used later
            str = Console.ReadLine(); // This warning is caused due to no error handling. This can be ignored.
                                      // We will go over error handling in a future video

            // Prints the string str to the console
            Console.WriteLine(str);

            // Reads input from the console then prints. Inner most functions get fully run FIRST
            Console.WriteLine(Console.ReadLine());
        }
    }
}
