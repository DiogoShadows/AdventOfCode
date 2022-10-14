using System;
using System.Collections.Generic;
using System.Linq;
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
            List<string> answer = new List<string>();
            List<List<string>> listCombinations = new List<List<string>>();

            foreach(var combination in COMBINATIONS1.Split("|").ToList())
            {
                List<string> model = combination.Split("->").ToList();
                listCombinations.Add(model);
            }

            foreach(char letter in INPUT1)
            {
                answer.Add(letter.ToString());
            }

            int steps = 40;

            for(int a = 0; a < steps; a++)
            {
                for (int i = 0; i < answer.Count() - 1; i++)
                {
                    string letter = listCombinations.First(x => x[0] == $"{answer[i]}{answer[i + 1]}")[1];
                    answer.Insert(i + 1, letter);
                    i++;
                }
            }

            int biggest = 0, smallest = 1000;

            string alreadyCounted = "";

            foreach(var letter in answer)
            {
                if(!alreadyCounted.Contains(letter))
                {
                    int count = answer.Count(x => x == letter);
                    biggest = Math.Max(biggest, count);
                    smallest = Math.Min(smallest, count);
                }
            }

            Console.WriteLine(biggest - smallest);
        }
    }
}
