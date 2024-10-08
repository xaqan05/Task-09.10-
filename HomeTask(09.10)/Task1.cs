/*namespace HomeTask_09._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNum = FindMin(23, 48, 55, 17, 14, 11, 3);
            Console.WriteLine(minNum);
        }

        static int FindMin(params int[] nums) {

            int minNum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if(nums[i] < minNum)
                {
                    minNum = nums[i];
                }
            }

            return minNum;
        }
    }
}
*/