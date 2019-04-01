using System;
using static System.Console;
using System.Linq;

namespace ParallelArray {
    public class ParallelStringArray {

        private string[ , ] array;
        public string[ , ] Array {
            get {
                return this.array;
            }
            set {
                this.array = value;
            }
        }
        public void ParallelArray(string[] arrayOne, string[] arrayTwo) {
            this.Array = createParallelArray(arrayOne, arrayTwo);
        }

        public bool inParallelArray(int arrayPos, string value) {
        // Loops through the array at the spcified index in the inputted parallel array to see if the wanted value is inside
        int length = this.Array.GetLength(arrayPos);
        bool found = false;
        for (int i = 0; i < length; i++) {
            found = value.Equals(this.Array[arrayPos, i]);
            if (found) break;
        }
        return found;
        }

        private static string[ , ] createParallelArray(string[] arrayOne, string[] arrayTwo) {
        // takes two arrays and splices them into a single, multi-dimensional array for better storage
        string [ , ] returnArray = new string[arrayOne.Length, arrayOne.Length];
        // WriteLine("Array one length: {0}, Array two length: {1}", arrayOne.Length, arrayTwo.Length);
        if (!arrayOne.Length.Equals(arrayTwo.Length)) {
            WriteLine("Cannot make parallel array with unequally sized arrays");
        } else {
            for (int i = 0; i < arrayOne.Length; i++) {
                returnArray[0, i] = arrayOne[i];
                returnArray[1, i] = arrayTwo[i];
            }
        }
        // WriteLine("Parallel Row one length: {0}, Parallel Row Two length: {1}", returnArray.GetLength(0), returnArray.GetLength(1));
        return returnArray;
        }

        public static void ToString() {
            // NEEDS FIXING. WORKS BUT IS HARDCODED
            // Loops through and prints each row and it's contents
            int numParallels = parallelArray.GetLength(0) / 2;
            WriteLine("Number of rows: {0}", numParallels);
            for (int i = 0; i < numParallels; i++) {
                int rowLength = parallelArray.GetLength(i);
                // WriteLine("Row length: {0}", rowLength);
                Write("Row {0}: ", i);
                for (int j = 0; j < rowLength; j++) {
                    if (rowLength.Equals(j + 1)) {
                        WriteLine(parallelArray[i, j]);
                    } else {
                        Write("{0}, ", parallelArray[i, j]);
                    }
                }
            }
        }
    }
}