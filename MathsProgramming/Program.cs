class Program1 {
    static void Main(string[] args) {
        Console.Write("Number 1: "); // Accept user input for number 1
        float Number1 = Convert.ToSingle(Console.ReadLine()); // Convert inputted number to Int32 value
        Console.Write("Number 2: "); // Accept user input for number 2
        float Number2 = Convert.ToSingle(Console.ReadLine()); // Same applies here

        // The operations + - / *
        Console.WriteLine("{0} + {1} = {2}", Number1, Number2, Number1 + Number2);
        Console.WriteLine("{0} - {1} = {2}", Number1, Number2, Number1 - Number2);
        Console.WriteLine("{0} / {1} = {2}", Number1, Number2, Number1 / Number2);
        Console.WriteLine("{0} * {1} = {2}", Number1, Number2, Number1 * Number2);
    }
}