using System;
public class Program
{
    static int RandomAccess(int[] nums)
    {
        Random random = new();

        int randomIndex = random.Next(nums.Length);

        return nums[randomIndex];
    }

    static int[] extend(int[] nums, int enlarge)
    {
        int[] res = new int[nums.Length + enlarge];

        for(int i=0; i<nums.Length; i++)
        {
            res[i] = nums[i];
        }

        return res;
    }

    //insert a number
    static void Insert(int[] nums, int num, int index)
    {
        // 把索引 index 以及之后的所有元素向后移动一位
        for (int i = nums.Length - 1; i > index; i--)
        {
            nums[i] = nums[i - 1];
        }
        // 将 num 赋给 index 处元素
        nums[index] = num;
    }

    static void Remove(int[] nums, int index)
    {
        for (int i = index; i < nums.Length -1; i++)
        {
            nums[i] = nums[i + 1];
        }
    }

    static void Traverse(int[] nums)
    {
        int count = 0;
        for(int i= 0; i<nums.Length; i++)
        {
            count++;
        }

        foreach(int num in nums)
        {
            count++;
        }
    }
    
    //find
    static int Find(int[] nums, int target)
    {
        for(int i=0; i < nums.Length; i++)
        {
            if(nums[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    public static void Main()
    {
        int[] array = { 1, 2, 34, 55, 7 };

        int value = Find(array, 2);
        Console.WriteLine(value); 
    }
}
