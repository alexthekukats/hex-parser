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
            int lines = 0;
            using (StreamReader sr = new StreamReader("sent_hex.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] hexes = line.Split(' ');

                    using (StreamWriter sw = new StreamWriter("hex.txt", append: true))
                    {
                        for (int i = 0; hexes.Length > i; i++)
                        {
                            if ((hexes[i] == ""))
                            {
                                break;
                            }
                            sw.Write("0x" + hexes[i][0] + hexes[i][1]);// + ", " + "0x" + hexes[i][2] + hexes[i][3] + ", ");
                        }
                        sw.WriteLine();
                        Console.WriteLine("Amount of line(s) processed: {0}", ++lines);
                    }
                }
            }
        }
    }
}
