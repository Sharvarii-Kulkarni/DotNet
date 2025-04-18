using System;
using System.IO;
class Binary
{
	static void Main()
	{
        string filePath = "binaryFile.dat";  // Binary file path

        // Write to binary file
        WriteToBinaryFile(filePath);

        // Read from binary file
        ReadFromBinaryFile(filePath);
    }
    static void WriteToBinaryFile(string filePath)
    {
        // Using FileStream to open the binary file
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        {
            // Create a BinaryWriter to write data to the file
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                Console.WriteLine("Writing to binary file...");

                // Write various types of data to the file
                writer.Write(123);            // Writing an integer
                writer.Write(45.67);          // Writing a double
                writer.Write("Hello, World!"); // Writing a string
                writer.Write(true);           // Writing a boolean

                Console.WriteLine("Data written to the binary file.");
            }
        }
    }

    static void ReadFromBinaryFile(string filePath)
    {
        // Using FileStream to open the binary file
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            // Create a BinaryReader to read data from the file
            using (BinaryReader reader = new BinaryReader(fs))
            {
                Console.WriteLine("Reading from binary file...");

                // Read the data from the file
                int intValue = reader.ReadInt32();    // Reading an integer
                double doubleValue = reader.ReadDouble(); // Reading a double
                string strValue = reader.ReadString(); // Reading a string
                bool boolValue = reader.ReadBoolean(); // Reading a boolean

                // Display the read values
                Console.WriteLine($"Integer: {intValue}");
                Console.WriteLine($"Double: {doubleValue}");
                Console.WriteLine($"String: {strValue}");
                Console.WriteLine($"Boolean: {boolValue}");
            }
        }
    }
}
