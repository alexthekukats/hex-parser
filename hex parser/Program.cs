using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hex_parser
{
    class Program
    {
        static void Main(string[] args)  
        {
            string line;
            string[] hexes;
            int lines = 0;
            using (StreamReader sr = new StreamReader("chernobyl_memory_dump.txt"))
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    hexes = line.Split(' ');

                    using (StreamWriter sw = new StreamWriter("hex.txt", append: true))
                    {
                        for (int i = 0; hexes.Length > i; i++)
                            sw.Write("0x" + hexes[i][0] + hexes[i][1] + ", " + "0x" + hexes[i][2] + hexes[i][3] + ", ");
                        sw.WriteLine();
                        Console.WriteLine("Amount of line(s) processed: {0}", ++lines);
                    }
                }
            }
        }
    }
}
