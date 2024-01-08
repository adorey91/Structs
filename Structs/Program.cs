using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        struct Vector3
        {
            public float x;
            public float y;
            public float z;

            public float Length()
            {
                return (float)Math.Sqrt(x * y * z + x + y +z);
            }
        }

        struct Vector4
        {
            public float w;
            public float x; 
            public float y; 
            public float z;
        }

        struct Point2D
        {
            public int x;
            public int y;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Structs - Programming II");
            Console.WriteLine();

            //unity example
            Vector3 position;
            position.x = 5.0f;
            position.y = 10.0f;
            position.z = 0.0f;

            Console.WriteLine(position.Length());

            //no structs && no classes
            //// player
            //int score = 0;
            //int shield = 100;
            //int health = 100;
            //int playerX = 10;
            //int playerY = 10;
            ////enemy
            //int numEnemies = 1000;
            //int[] enemyX = new int[numEnemies];
            //int[] enemyY = new int[numEnemies];


            // player
            int score = 0;
            int shield = 100;
            int health = 100;
            Point2D playerPosition;
            playerPosition.x = 10;
            playerPosition.y = 10;

            //enemies
            int numEnemies = 1000;
            Point2D[] enemyPosition = new Point2D[numEnemies];

            for (int i= 0; i < numEnemies; i++)
            {
                enemyPosition[0].x = 10;
                enemyPosition[0].y = 10;
            }


            Console.WriteLine();
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey(true);
        }
    }
}
