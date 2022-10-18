using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Days
{
    public class Day_14
    {
        public static string COMBINATIONS1 = "CH->B|HH->N|CB->H|NH->C|HB->C|HC->B|HN->C|NN->C|BH->H|NC->B|NB->B|BN->B|BB->N|BC->B|CC->N|CN->C";
        public static string INPUT1 = "NNCB";
        public static string COMBINATIONS2 = "PB->F|KC->F|OB->H|HV->N|FS->S|CK->K|CC->V|HF->K|VP->C|CP->S|HO->N|OS->N|HS->O|HB->F|OH->V|PP->B|BS->N|VS->F|CN->B|KB->O|KH->B|SS->K|NS->B|BP->V|FB->S|PV->O|NB->S|FC->F|VB->P|PC->O|VF->K|BV->K|OO->B|PN->N|NH->H|SP->B|KF->O|BN->F|OF->C|VV->H|BB->P|KN->H|PO->C|BH->O|HC->B|VO->O|FV->B|PK->V|KO->H|BK->V|SC->S|KV->B|OV->S|HK->F|NP->V|VH->P|OK->S|SO->C|PF->C|SH->N|FP->V|CS->C|HH->O|KK->P|BF->S|NN->O|OC->C|CB->O|BO->V|ON->F|BC->P|NO->N|KS->H|FF->V|FN->V|HP->N|VC->F|OP->K|VN->S|NV->F|SV->F|FO->V|PS->H|VK->O|PH->P|NF->N|KP->S|CF->S|FK->P|FH->F|CO->H|SN->B|NC->H|SK->P|CV->P|CH->H|HN->N|SB->H|NK->B|SF->H";
        public static string INPUT2 = "KFFNFNNBCNOBCNPFVKCP";

        public static void Program()
        {
            List<List<string>> numberCombinationsInAString = new List<List<string>>();
            List<List<string>> buffer = new List<List<string>>();
            List<List<string>> listCombinations = new List<List<string>>();

            foreach (var combination in COMBINATIONS2.Split("|").ToList())
            {
                List<string> model = combination.Split("->").ToList();
                listCombinations.Add(model);
            }

            List<List<string>> letters = new List<List<string>>();

            for (int i = 0; i < INPUT2.Length; i++)
            {
                if (letters.Any(x => x[0] == INPUT2[i].ToString()))
                {
                    var number = Int64.Parse(letters.First(x => x[0] == INPUT2[i].ToString())[1]);
                    letters.First(x => x[0] == INPUT2[i].ToString())[1] = $"{number + 1}";
                }

                else
                    letters.Add(new List<string> { INPUT2[i].ToString(), "1" });

                if(i < INPUT2.Length - 1)
                {
                    if (numberCombinationsInAString.Any(x => x[0] == $"{INPUT2[i]}{INPUT2[i + 1]}"))
                    {
                        var number = Int64.Parse(numberCombinationsInAString.First(x => x[0] == $"{INPUT2[i]}{INPUT2[i + 1]}")[1]);
                        numberCombinationsInAString.First(x => x[0] == $"{INPUT2[i]}{INPUT2[i + 1]}")[1] = $"{number + 1}";
                    }

                    else
                        numberCombinationsInAString.Add(new List<string> { $"{INPUT2[i]}{INPUT2[i + 1]}", "1" });
                }
            }

            int steps = 10;

            for(int a = 0; a < steps; a++)
            {
                buffer = new List<List<string>>();

                foreach(var combination in numberCombinationsInAString)
                {
                    buffer.Add(new List<string> { combination[0], "0" });
                }

                for(int i = 0; i < numberCombinationsInAString.Count(); i++)
                {
                    var value = Int64.Parse(numberCombinationsInAString[i][1]);

                    if(value > 0)
                    {
                        string newString1 = $"{numberCombinationsInAString[i][0][0]}{listCombinations.First(x => x[0] == numberCombinationsInAString[i][0])[1]}";
                        string newString2 = $"{listCombinations.First(x => x[0] == numberCombinationsInAString[i][0])[1]}{numberCombinationsInAString[i][0][1]}";

                        var letter = listCombinations.First(x => x[0] == numberCombinationsInAString[i][0])[1];

                        if (letters.Any(x => x[0] == letter))
                        {
                            var number = Int64.Parse(letters.First(x => x[0] == letter)[1]);
                            letters.First(x => x[0] == letter)[1] = $"{number + value}";
                        }

                        else
                            letters.Add(new List<string> { letter, $"{value}" });

                        if (buffer.Any(x => x[0] == newString1))
                        {
                            var number = Int64.Parse(buffer.First(x => x[0] == newString1)[1]);
                            buffer.First(x => x[0] == newString1)[1] = $"{number + value}";
                        }

                        else
                            buffer.Add(new List<string> { newString1, value.ToString() });

                        if(buffer.Any(x => x[0] == newString2))
                        {
                            var number = Int64.Parse(buffer.First(x => x[0] == newString2)[1]);
                            buffer.First(x => x[0] == newString2)[1] = $"{number + value}";
                        }

                        else
                            buffer.Add(new List<string> { newString2, value.ToString() });
                    }
                }

                numberCombinationsInAString = new List<List<string>>();

                foreach (var combination in buffer)
                {
                    if(Int64.Parse(combination[1]) > 0)
                        numberCombinationsInAString.Add(combination);
                }
            }

            long biggest = 0, smallest = 9999999999999;

            for(int i = 0; i < letters.Count(); i++)
            {
                biggest = Math.Max(Int64.Parse(letters[i][1]), biggest);
                smallest = Math.Min(Int64.Parse(letters[i][1]), smallest);
            }

            Console.WriteLine(biggest - smallest);
        }
    }
}
