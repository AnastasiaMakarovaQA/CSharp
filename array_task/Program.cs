int[] array = {1, 34, 75, 37, 98, 234, 985, 35};
int n = array.Length;
int find = 37;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index); 
           }    
    index++;
}