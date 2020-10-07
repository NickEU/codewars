namespace Codewars.kyu5
{
    internal class MovingZeroesToTheEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var arrLen = arr.Length;
            // an array of integers is initialized with 0s 
            var result = new int[arrLen];
            var i = 0;

            foreach (var num in arr)
            {
                if (num != 0)
                {
                    result[i++] = num;
                }
            }

            return result;
        }
    }
}
