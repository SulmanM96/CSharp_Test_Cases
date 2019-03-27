using System;
using System.Collections.Generic;
using System.Text;

namespace lab_19_collections
{

    public class CollectionProject
    {
        static int[,,] myCubicArray = new int[11, 11, 11];
        
        // have to make static as is for labs 1 and 2


        // used for lab 3
        static Dictionary<string, string> dictionary = new Dictionary<string, string>();

        // used for lab 4
        static Queue<int> queue = new Queue<int>();

        // used for lab 5
        static Stack<int> stack = new Stack<int>();

        /*
         
        ### Lab 1 : Cubic Array 10x10x10
      */
        public int CubicArray()
        {
            for (int i = 0; i <= 10; i++)
            { for (int x = 0; x <= 10; x++)
            { for (int y = 0; y <= 10; y++)
            { myCubicArray[i, x, y] = i * x * y; }
            }
        }    return myCubicArray[2, 3, 7];
    }
          // ### Lab 2 : THE LIST

        public int List()
        {
            var List01 = new List<int>();

            for (int i = 0; i <= 10; i++)
            { for (int x = 0; x <= 10; x++)
            { for (int y = 0; y <= 10; y++)
            { List01.Add(myCubicArray[i, x, y]); } }
            }
            int ans = 0;
            foreach (int i in List01)
            {
                ans += i;
            }
            return ans;
        }

        //  ### Lab 3 : Dictionary (conquering the world!)
            

        public Dictionary<string, string> DictionaryTest()
        {

            dictionary.Add("Afghanistan", "Kabul");
            dictionary.Add("Albania", "Tirana");
            dictionary.Add("Algeria", "Algiers");
            dictionary.Add("Andorra", "Andorra la Vella");
            dictionary.Add("Angola", "Luanda");
            dictionary.Add("Argentina", "Buenos Aires");
            dictionary.Add("Armenia", "Yerevan");
            dictionary.Add("Austria", "Vienna");
            dictionary.Add("Azerbaijan", "Baku");
            dictionary.Add("Australia", "Canberra");

            Console.WriteLine(string.Join(", ", dictionary));

            return dictionary;
        }     
        //  ### Lab 4 : Queue
            
        public int QueueTest()
        {
            var Que = new Queue<int>();

            for (int i = 0; i <= 100; i++)

            {
                Que.Enqueue(i * i * i);
            }

            int total = 0;

            for (int i = 0; i <= 10; i++)

            {
                total += Que.Dequeue();
            }

            return total;
        }




        /*
        * 
        * 
            ### Lab 5 : Stack
            Repeat this for a stack ie count from 1 to 100, 
            add the cube of each number to the stack, 
            then `pop` 10 items off the top of the stack 
            and sum the output of those 10 numbers.
            Return this sum
        *
        * 
        * 
        */

        public int StackTest()
        {
            int sum;
            for (int i = 1; i < 101; i++)
            {
                stack.Push(i * i * i);
            }

            sum = stack.Pop();
            for (int i = 0; i < 9; i++)
            {

                sum = sum + stack.Pop();
            }

            return sum;
        }



    }
}