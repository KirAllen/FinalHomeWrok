
string [] array = {"Python", "2", "int", "3", "world", "hello"};


SrotArray(array);

void SrotArray(string[] array)
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



