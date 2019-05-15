using System;
using System.IO;
using static System.Console;

class AccessSomeNames {
    static void Main() {
        string path = Directory.GetCurrentDirectory();
        FileStream file = new FileStream(path+"\\Names.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);
        const int END = 999;
        int count = 0, num, size;
        string name;
        name = reader.ReadLine();
        while (name != null) {
            count++;
            name = reader.ReadLine();
        }
        size = (int) file.Length / count;
        do {
            WriteLine("With which number do you want to start?");
            Write("  (Enter {0} to quit): ", END);
            num = Convert.ToInt32(ReadLine());
            if (num == END) { break; }
            WriteLine("Starting with name {0}:", num);
            file.Seek((num - 1) * size, SeekOrigin.Begin);
            name = reader.ReadLine();
            WriteLine(" {0}", name);
            while (name != null) {
                name = reader.ReadLine();
                WriteLine(" {0}", name);
            }
        } while (num != END);
        reader.Close();
        file.Close();
    }
}