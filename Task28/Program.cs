 

int[] ReturnArray(int[] array)
{
    int[] arr = new int[array.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = array[i];
    }
    return arr;
}

