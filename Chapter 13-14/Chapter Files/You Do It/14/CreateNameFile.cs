using System;
using static System.Console;
using System.IO;

class CreateNameFile {
    static void Main() {
        string path = Directory.GetCurrentDirectory();
        string fileName = "\Names.txt";
        WriteLine("Path: {0}{1}", path, fileName);
        FileStream file = new FileStream(path+fileName, FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(file);
        string[] names = {"Anthony ", "Belle   ", "Carolyn ", "David   ", "Edwin   ", "Frannie ", "Gina    ", "Hannah  ", "Inez    ", "Juan    "};
        for (int i = 0; i < names.Length; i++) {
            writer.WriteLine(names[i]);
        }
        writer.Close();
        file.Close();
    }
}