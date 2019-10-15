using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            var t3list = new List<Tank>();
            var panteraList = new List<Tank>();
            int liveT34 = 0;
            int liveP = 0;
            for (int i = 0; i < 3; i++)
            {
                t3list.Add(new Tank("t34 - " + i));
                panteraList.Add(new Tank("Pantera - " + i));
                liveT34 += t3list[i].health;
                liveP += panteraList[i].health;

            }
            Console.WriteLine("T34 = " + Tank.Life(t3list) + "   Pantera " + Tank.Life(panteraList));


            while ((liveT34 > 0 || liveT34 > 0) && (t3list.Count > 0 || panteraList.Count > 0))
            {

                for (var i = 0; i < t3list.Count; i++) 
                { 
                    Tank T34 = t3list[i];

                    for (var j = 0; j < panteraList.Count; j++)
                    {
                        Tank TankPanter = panteraList[j];

                        var a = t3list[i] * panteraList[j];

                        Tank.print(T34, TankPanter);

                       
                        liveT34 -= TankPanter.loss ;
                        liveP -= T34.loss;

                        if (TankPanter.health <= 0)
                        {
                            TankPanter.IsDead(panteraList);

                        }

                        if (T34.health <= 0)
                        {
                            T34.IsDead(t3list);
                        }
                        for (int i1 = 0; i1 < t3list.Count; i1++)
                        {
                            Console.WriteLine($"T34 {i1} = " + t3list[i1].health);                         
                        }
                        for (int i2 = 0; i2 < panteraList.Count; i2++)
                        {
                            Console.WriteLine($" Pantera {i2} = " + panteraList[i2].health);                            
                        }


                                              
                        Console.WriteLine("T34 = " + Tank.Life(t3list) + "   Pantera " + Tank.Life(panteraList));

                    }
                }


            }
            if (Tank.Life(t3list)> Tank.Life(panteraList))
            {
                Console.WriteLine("Winner Command T-34");
                
            }
            else Console.WriteLine("Winner Command Pantera");




        }

    }
}