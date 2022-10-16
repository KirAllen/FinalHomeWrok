
string [] array = {"Python", "2", "int", "3", "world", "hello"};


SortArray(array);

void SortArray(string[] array)
{
    string[] newarr = new string[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            newarr[i]=array[i];;
            Console.Write($"{newarr[i]}" + ", ");
        }
    }
}



