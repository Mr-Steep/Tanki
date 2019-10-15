using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{ 
    public class Tank
    {
        private static Random rnd = new Random(DateTime.Now.Millisecond);

        public string Name { get; set; }

        public int Mob { get; set; }        
        public int Mask { get; set; }      
        public int Exp { get; set; }  
        public int loss { get; set; }
        public int health { get; set; }    

        public Tank(string name)
        {
            Mob = rnd.Next(1, 100);// маневринность
            Mask = rnd.Next(1, 10); // маскировка
            Exp = rnd.Next(1, 10); // опыт
            loss = rnd.Next(5, 10); // урон
            health = rnd.Next(80, 110); // жизни
            Name = name;
         
        }

        static int i = 1;
        public static int Life(List<Tank> tanks)
        {
            int sum = 0;
            Tank[] newarr = tanks.ToArray();
            for (int i = 0; i < newarr.Length; i++)
            {
                sum += newarr[i].health;
            }
            return sum;
        }

        public void IsDead (List<Tank> tank)
        {
            for (var i = 0; i< tank.Count; i++)
            {
                if (tank[i].health <=0)
                {
                    tank.Remove(tank[i]);
                }
            }

        }

        public static void print(Tank tank1, Tank tank2)
        {
            Console.WriteLine("TANK 1 " + tank1.Name + "    " + "TANK 2 " + tank2.Name);
            Console.WriteLine("Mob tank1 = " + tank1.Mob + "    " + "Mob tank2 = " + tank2.Mob);
            Console.WriteLine("Mask tank1 = " + tank1.Mask + "    " + "Mask tank2 = " + tank2.Mask);
            Console.WriteLine("Exp tank1 = " + tank1.Exp + "    " + "Exp tank2 = " + tank2.Exp);
            Console.WriteLine("loss tank1 = " + tank1.loss + "    " + "loss tank2 = " + tank2.loss);
            Console.WriteLine("health tank1 = " + tank1.health + " " + "health tank2 = " + tank2.health);
        }


        public static bool operator * (Tank tank1, Tank tank2)
        {
            if (tank1.health > 0 && tank2.health > 0)
            {
                int Par1 = tank1.Mob + tank1.Mask + tank1.Exp;
                int Par2 = tank2.Mob + tank2.Mask + tank2.Exp;


                Console.WriteLine("Boi " + i++);
                Console.WriteLine();
                Console.WriteLine();

                if (Par1 > Par2)
                {
                    Console.WriteLine($" Winner Tank T-34 {tank1.Name} ");
                    tank2.health -= tank1.loss;
                    tank1.health -= tank2.loss / 2;
                    tank1.Exp++;
                    tank2.Exp++;
                    tank2.Mask++;
                    return true;
                }


                else
                {
                    Console.WriteLine($" Winner Tank Pantera {tank2.Name} ");
                    tank1.health -= tank2.loss;
                    tank2.health -= tank1.loss / 2;
                    tank2.Exp++;
                    tank1.Exp++;
                    tank1.Mask++;
                    return true;
                }
            }

                return true;
           
        }

    
    }
}
