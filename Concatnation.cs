class Program
{
    static int[] GetConcatenation(int[] nums)
    {
        int n = nums.Length;
        int[] ans = new int[2 * n];

        for (int i = 0; i < n; i++)
        {
            ans[i] = nums[i];
            ans[i + n] = nums[i];
        }

        return ans;
    }

    static void Main1(string[] args)
    {
        int[] nums = { 1, 2, 1 };
        int[] result = GetConcatenation(nums);
        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
    }
}