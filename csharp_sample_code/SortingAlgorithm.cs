
using System;

/// <summary>
/// Provides sorting algorithms for arrays.
/// </summary>
public static class SortingAlgorithm
{
    /// <summary>
    /// Sorts an array using the bubble sort algorithm.
    /// </summary>
    public static void BubbleSort<T>(T[] arr) where T : IComparable<T>
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j].CompareTo(arr[j + 1]) > 0)
                {
                    T temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
