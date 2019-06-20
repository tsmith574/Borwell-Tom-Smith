using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeOfRoom
{
    //Setting a class for the area of the floor
    public class Area
    {
        public int length;
        public int Floorwidth;
        public int Floorheight;
        public int WallWidth;
        public int WallHeight;


        public Area()
        {
            Console.WriteLine("Please enter the height of the floor");
            Floorheight = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width of the floor");
            Floorwidth = int.Parse(Console.ReadLine());
        }
        //This is the calculation to work out the area of the floor
        public int area1()
        {
            return Floorheight * Floorwidth;
        }
        //This part of the code collects the input for the height and width of the wall
        public class walls : Area
        {
            public walls()
            {
                Console.WriteLine("Please enter the height of the wall");
                WallHeight = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the wall");
                WallWidth = int.Parse(Console.ReadLine());
            }
            public int Wall()
            {
                return WallHeight * WallHeight * 2 + (WallHeight * WallHeight * 2) + Floorheight * Floorwidth;
            }

            //Setting a class for the volume of the room
            public class Volume : walls
            {
                public Volume()
                {
                    Console.WriteLine("Please enter the length of the room");
                    length = int.Parse(Console.ReadLine());
                }
                //This section of code works out the volume of the room
                public int volume()
                {
                    return length * WallWidth * WallHeight;
                }
            }


            //This area of code displays the answers
            class Displaying
            {
                public static void Main(string[] args)
                {
                    Volume Room = new Volume();

                    int A = Room.area1();
                    Console.WriteLine("The area of the floor = " + A + " Metres Squared");

                    int V = Room.volume();
                    Console.WriteLine("The volume of the room = " + V + " Metres Cubed");

                    int W = Room.Wall();
                    Console.WriteLine("The area of the whole room = " + W + " Metres Squared");
                    if (W >= 12)
                    {
                        Console.WriteLine("You will need 2L of paint to cover the walls");
                    }
                    else if (W < 12)
                    {
                        Console.WriteLine("You will need 1L of paint to cover the walls");
                    }
                    else
                    {
                        Console.WriteLine("You will need 5L of paint to cover the walls");
                    }

                    Console.ReadKey();

                }
            }
        }
    }
}

