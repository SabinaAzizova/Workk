using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Bullet
    {
        public int CapacityBullet;
        public int CurrentBullet;
        public bool Firemode;
        public string Shoot;
        public void _shoot(int FireMode)
        {
            if ( FireMode==1)
            {
                for (int i = 0; i < CapacityBullet; i++) 

                return  Shoot;
            }
        }
      
            public bool _firemode
        {
            get
            {
                return true;
            }



            set
            {
                if (_firemode == Avtomatik)
                {
                   _firemode = value;
               }
           }
        }
        public static (GetRemainBulletCount(int num));

        int GetRemainBulletCount()
        {
           static string GetRemainBulletCount = "";

            int GetRemainBulletCount = CapaticyBullet - CurrentBullet;
                    if(CurrentBullet= CapaticyBullet)
                    return GetRemainBulletCount;
                else
                {
                    GetRemainBulletCount++;
                    //return true
                }
            }
        }




    }



//public void Shoot()
//            if (FireMode)

//    for (i = 0, i < FireMode.Length, i++)
//int i = 0;
                //for (int j = 0; j < CapacityBullet; j++)
