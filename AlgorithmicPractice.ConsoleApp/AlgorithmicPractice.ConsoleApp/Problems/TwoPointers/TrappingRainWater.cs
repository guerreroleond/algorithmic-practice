namespace AlgorithmicPractice.ConsoleApp.Problems.TwoPointers;

public class TrappingRainWater
{

    public static int SolveCleanedUp(int[] peaks)
    {
        int left = 0;
        int right = peaks.Length - 1;
        int maxLeft = 0;
        int maxRight = 0;
        int water = 0;

        while(left < right)
        {
            if(peaks[left] < peaks[right])
            {
                if(peaks[left] >= maxLeft)
                    maxLeft = peaks[left];
                else
                    water += maxLeft - peaks[left];

                left++;
            }
            else
            {
                if(peaks[right] >= maxRight)
                    maxRight = peaks[right];
                else
                    water += maxRight - peaks[right];

                right--;
            }
        }

        return water;
    }

    public static int Solve(int[] peaks)
    {
        var left = 0;
        var right = peaks.Length - 1;
        var maxLeft = peaks[left];
        var maxRight = peaks[right];
        int current = (maxLeft < maxRight) ? left : right;
        int water = 0;
        
        while(left < right)
        {
            var lowMax = Math.Min(maxLeft, maxRight);
            var currWater = lowMax - peaks[current];
            water += (currWater > 0) ? currWater : 0;

            if(maxLeft < maxRight)
            {
                left++;
                maxLeft = Math.Max(maxLeft, peaks[left]);
                current = left;
            } 
            else
            {
                right--;
                maxRight = Math.Max(maxRight, peaks[right]);
                current = right;                 
            } 
        }

        return water;
    }
}
