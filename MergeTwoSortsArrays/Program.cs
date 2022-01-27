using MergeTwoSortsArrays;

//creating
int[] arr1 = (int[])GenArray.NewArray(4);
int[] arr2 = (int[])GenArray.NewArray(8);

//sorting
Array.Sort(arr1);
Array.Sort(arr2);

//out 2 arrays(in my task did not enter to sort them)
Console.WriteLine("Generated and sorted array 1:");
foreach (var el in arr1)
{
    Console.Write(el + " ");
}

Console.WriteLine("\nGenerated and sorted array 2:");
foreach (var el in arr2)
{
    Console.Write(el + " ");
}

//---------------------------------------------------------

int len = arr1.Length + arr2.Length;
int [] arr3 = new int[len];

int i = 0, j = 0;
//merging arrays 
while(i+j<len)
{
    if (arr1[i]<= arr2[j])
    {
        arr3[i+j] = arr1[i];
        if (i == arr1.Length-1)
        {
            
            for(;j< arr2.Length; j++ )
            {
                arr3[i + j + 1] = arr2[j];
            }
            break;
        }
        i++;
    }
    else
    {
        arr3[i + j] = arr2[j];
        if (j == arr2.Length-1)
        {
            
            for (; i < arr1.Length; i++)
            {
                arr3[i + j + 1] = arr1[i];
            }
            break;
        }    
        j++;
    }
}

//out resulting new array
Console.WriteLine("\nMerged arrays:");
foreach (var el in arr3)
{
    Console.Write(el + " ");
}
Console.WriteLine();