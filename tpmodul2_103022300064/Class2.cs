using System;


namespace tpmodul2_103022300064
{
    static class Program
    {
        public static void Main()
        {
            MyFunction newObj = new MyFunction();

            Console.WriteLine("= = = = = Tugas A = = = = = ");
            Console.WriteLine("Masukkan satu Huruf : " );
            char input = Convert.ToChar(Console.ReadLine());


            Console.WriteLine(newObj.chooseChar(input));

            Console.WriteLine("= = = = = Tugas B = = = = = ");
            newObj.printArrEvenIntegers();
        }
    }

    public class MyFunction
    {
        public string chooseChar(char input)
        {
            if (input == 'A' || input == 'I' || input == 'U' || input == 'E' || input == 'O')
            { 
                return "Huruf " + input + " merupakan huruf Vokal";
            }
            else
            {;
                return "Huruf " + input + " merupakan huruf Konsonan";
            }
        }

        public void printArrEvenIntegers()
        {
            int[] arrAngka = [2, 4, 6, 8, 10];

            for (int i = 1; i < arrAngka.Length+1; i++)
            {
                Console.WriteLine("Angka Genap " + i + " : " + arrAngka[i-1]);
            }
        }
    }
}

