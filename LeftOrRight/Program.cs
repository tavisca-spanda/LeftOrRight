using System;
using System.Linq;

namespace CodeJam
{
    class LeftOrRight
    {
        int MaxDistance(string program)
        {
            
            int left = 0, right = 0, leftMAx = 0, rightMax = 0;
           

            
            foreach(char c in program)
            {
                if (c == 'L')
                {
                    
                    left--;
                    right--;
                    if (left < leftMAx)
                        leftMAx = left;
                }
                    
                else if (c == 'R')
                {
                    
                    left++;
                    right++;
                    if (right > rightMax)
                        rightMax = right;
                }

                else
                {
                    left--;
                    right++;
                    if (left < leftMAx)
                        leftMAx = left;
                    if (right > rightMax)
                        rightMax = right;
                    
                }

               

                    

            }
            if (leftMAx * -1 > rightMax)
                return leftMAx * -1;
            else
                return rightMax;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            LeftOrRight leftOrRight = new LeftOrRight();
            String input = Console.ReadLine();
            do
            {
                Console.WriteLine(leftOrRight.MaxDistance(input));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
    

    
}