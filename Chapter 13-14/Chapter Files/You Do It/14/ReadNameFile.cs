using System;
using System.IO;
using static System.Console;

class ReadNameFile {
    static void Main() {
        string path = Directory.GetCurrentDirectory();
        // WriteLine("Current Path: {0}", path);
        FileStream file = new FileStream(path+"\\Names.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);
        int count = 1;
        string name;
        WriteLine("Displaying all names");
        name = reader.ReadLine();
        while (name != null) {
            WriteLine("{0} {1}", count, name);
            name = reader.ReadLine();
            count++;
        }
        reader.Close();
        file.Close();
    }
}