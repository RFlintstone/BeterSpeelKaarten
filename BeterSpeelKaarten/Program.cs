using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeterSpeelKaarten
{
    class Program
    {
        public static void Main(string[] args)
        {
            SpeelKaart[] pak = new SpeelKaart[52];
            int positie = 0;
            int soort = -1;
            int pakKaart = 52;
            int jokers = 2;
            int perSymbool = ((pakKaart - jokers) / 4);

            foreach (Symbool symbool in Enum.GetValues(typeof(Symbool))) //4x
            {
                for (int i = 0;  i < perSymbool; i++)
                {
                    pak[positie] = new SpeelKaart(i, soort, true);

                    if (i == 11)
                    {
                        pak[positie] = new SpeelKaart(i, soort, true, Personage.Boer);
                    }
                    if (i == 12)
                    {
                        pak[positie] = new SpeelKaart(i, soort, true, Personage.Koningin);
                    }
                    if (i == 13)
                    {
                        pak[positie] = new SpeelKaart(i, soort, true, Personage.Koning);
                    }

                    positie++;
                    Console.ReadLine();
                }

                for (int i = 0; i < pak.Length; i++)
                {
                    Console.WriteLine(pak[i].Symbool + "-" + pak[i].Waarde);
                }
                Console.Read();
            }

        }
    }
}
