using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SkibidiCasino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit) {
                Console.Clear();
                Console.WriteLine("-----Skibidi Casino Main Menu-----");
                Console.WriteLine("(1)---Black Jack---(1)");
                Console.WriteLine("(2)---Roulette---(2)");
                Console.WriteLine("(3)---Póker---(3)");
                Console.WriteLine("(4)---Wheel---(4)");
                Console.WriteLine("(5)---Lóverseny---(5)");
                Console.WriteLine("(6)---Exit---(6)");
                Console.WriteLine("======================");
                Console.Write("Válassz egy opciót! 1-5 ig ha játszani szeretnél, ha nem nyomd meg a 6-os gombot ");

                string dontesinput = Console.ReadLine();

                switch (dontesinput) 
                {
                    case "1":
                        Console.WriteLine("");
                        Console.WriteLine("A \"Black Jack-et\" választottad");
                        Console.WriteLine("");
                        Console.WriteLine("========Szabályzat========"); ;
                        Console.WriteLine("");
                        Console.WriteLine("A cél az, hogy a játékosok keze közelebb kerüljön a 21-hez, mint az osztóé, anélkül hogy túllépnék azt");
                        Console.WriteLine("Kártyák értékei:");
                        Console.WriteLine("Számkártyák (2–10): saját értékük.");
                        Console.WriteLine("Képes kártyák (J, Q, K): 10 pont.");
                        Console.WriteLine("Ász: 1 vagy 11 pont, a játékos választása szerint.");
                        Console.WriteLine("A játékosok és az osztó 2-2 kártyát kapnak");
                        Console.WriteLine("A játékosok kártyái mind láthatóak, az osztó egy kártyája pedig le van fordítva.");
                        Console.WriteLine("Blackjack:");
                        Console.WriteLine("Ha az első két kártya összege pontosan 21 az blackjack, ami azonnali győzelem.");
                        Console.WriteLine("");
                        Console.WriteLine("========Szabályzat========");
                        break;

                    case "2":
                        Console.WriteLine("");
                        Console.WriteLine("A \"Roulette-t\" választottad");
                        Console.WriteLine("");
                        Console.WriteLine("========Szabályzat========");
                        Console.WriteLine("");
                        Console.WriteLine("A játék célja: ");
                        Console.WriteLine("Találd el, melyik számra, színre vagy számtartományra fog megállni a rulettkerék.");
                        Console.WriteLine("A rulettkerék:");
                        Console.WriteLine("Európai rulett: 37 rekesz (1–36 és egy 0 amin nagyobb a nyerési szorzó).");
                        Console.WriteLine("A számok pirosak vagy feketék, a 0 (és a 00) zöld.");
                        Console.WriteLine("Belső fogadások: ");
                        Console.WriteLine("Egyetlen számra vagy kis csoportokra: Egy szám (Straight Up).\r\nKét szám (Split).\r\nHárom szám (Street).\r\nNégy szám (Corner).\r\nHat szám (Line). ");
                        Console.WriteLine("Külső fogadások (nagyobb csoportokra vagy jellemzőkre):");
                        Console.WriteLine("Piros vagy fekete.\r\nPáros vagy páratlan.\r\nAlacsony (1–18) vagy magas (19–36).\r\nOszlopfogadás (Column).\r\nTucatok (1–12, 13–24, 25–36).");
                        Console.WriteLine("");
                        Console.WriteLine("========Szabályzat========");

                        break;

                    case "3":
                        Console.WriteLine("");
                        Console.WriteLine("A \"Póker-t\" választottad");
                        Console.WriteLine("");
                        Console.WriteLine("========Szabályzat========");
                        Console.WriteLine("");
                        Console.WriteLine("Játék célja: ");
                        Console.WriteLine("A legjobb 5 lapból álló kombináció kialakítása a saját 2 zárt lapodból és az asztalon lévő közös lapokból.\r\nMásik lehetőség, hogy a többi játékost blöfföléssel tét visszalépésére kényszeríted.");
                        Console.WriteLine("A játék menete: ");
                        Console.WriteLine("Osztás: Minden játékos 2 zárt lapot kap, amelyeket csak ő lát.\r\nKözös lapok: Az osztó az asztalra összesen 5 közös lapot helyez, fokozatosan (3+1+1 elosztásban).");
                        Console.WriteLine("Tétkörök: ");
                        Console.WriteLine("Pre-Flop: Az első tétkör a zárt lapok kiosztása után.\r\nFlop: 3 közös lap felfedése után következik a második tétkör.\r\nTurn: A 4. közös lap felfedése utáni tétkör.\r\nRiver: Az 5. közös lap felfedése utáni utolsó tétkör.");
                        Console.WriteLine("Tétek és akciók:");
                        Console.WriteLine("Check: Nem teszel tétet, de nem is lépsz ki.\r\nBet: Tétet teszel.\r\nCall: Megadod az előző tétet.\r\nRaise: Emelsz az előző tét összegén.\r\nFold: Lemondasz a lapjaidról, és nem veszel részt a további játékban.");
                        Console.WriteLine("Nyertes meghatározása:");
                        Console.WriteLine("A játékosok a legjobb 5 lapos combo-val mérkőznek, vagy mindenki bedobja a lapjait, és az utolsó játékban maradó nyer.");
                        Console.WriteLine("");
                        Console.WriteLine("========Szabályzat========"); 
                        break;

                    case "4":
                        Console.WriteLine("");
                        Console.WriteLine("A \"Wheel-t\" választottad");
                        Console.WriteLine("");
                        Console.WriteLine("========Szabályzat========");
                        Console.WriteLine("");
                        Console.WriteLine("A kerék felépítése: ");
                        Console.WriteLine("A kerék több szektorra van osztva, amelyek számokkal, szimbólumokkal vagy színes mezőkkel vannak megjelölve.\r\nMinden szektornak különböző esélyei és kifizetései vannak.\r\nA szektorok egy rögzített mutatónál állnak meg, amely kijelöli a nyertes területet.");
                        Console.WriteLine("Fogadások: ");
                        Console.WriteLine("A játékosok a kerék megpörgetése előtt fogadnak arra, hogy szerintük melyik szektornál fog megállni a kerék.\r\nA fogadási lehetőségek közé tartozhatnak:\r\nKonkrét számok/szimbólumok/Színek.\r\nSpeciális szektorok (pl. jackpot vagy bónuszmezők).");
                        Console.WriteLine("Játék menete: ");
                        Console.WriteLine("fogadások elhelyezése után a kerék pörögni kezd.\r\nA kerék megállása után a mutató jelzi a nyertes szektort.\r\nAz osztó kifizeti a nyertes téteket, és begyűjti a veszteseket.");
                        Console.WriteLine("");
                        Console.WriteLine("========Szabályzat========");
                        break;

                    case "5":
                        Console.WriteLine("");
                        Console.WriteLine("A \"Lóverseny-t\" választottad");
                        Console.WriteLine("");
                        Console.WriteLine("========Szabályzat========");
                        Console.WriteLine("");
                        Console.WriteLine("A verseny célja: ");
                        Console.WriteLine("A lovak a zsokékkal együtt egy előre kijelölt távot teljesítenek.\r\nAz nyer, aki elsőként halad át a célvonalon.");
                        Console.WriteLine("A versenytávok: ");
                        Console.WriteLine("A távok általában 800 és 3200 méter között változnak.\r\nA pontos távot a verseny előre meghatározza, és a pálya típusa (síklóverseny, akadályverseny) is eltérő lehet.");
                        Console.WriteLine("Szabályok a verseny során: ");
                        Console.WriteLine("A lovaknak a pálya kijelölt útvonalán kell maradniuk.\r\nA zsokék nem akadályozhatják szándékosan egymást.\r\nHa egy ló vagy zsoké szabálytalankodik, kizárhatják vagy hátrasorolhatják őket.\r\nSérülés vagy baleset esetén a versenyt leállíthatják, illetve újraindíthatják.");
                        Console.WriteLine("");
                        Console.WriteLine("========Szabályzat========");
                        break;

                    case "6":
                        Console.WriteLine("Kiléptél");
                        exit = true;
                        break;

                        default:
                        Console.WriteLine("Nem jól választottál próbald újra te majom");
                        break ;

                }
                if (!exit)
                {
                    Console.WriteLine("\nNyomj meg bármilyen gombot hogy visszalépj a menübe ");
                    Console.ReadKey();


                            }

            }
        }
    }
}
