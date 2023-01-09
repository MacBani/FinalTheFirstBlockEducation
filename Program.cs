string [] str = {"hello", "2", "world", ":-)"};
int SizeStr = str.Length;
int SizeElement = 0;

for(int i = 0; i < SizeStr; i++)
{
    SizeElement = str[i].Length;
    
    if(SizeElement > 3)
    {
        str = str.Where(q => q != str[i]).ToArray();
        SizeStr = str.Length; // Размер изменённого массива
        i = 0; 
    }
   
    
}

for(int i = 0; i < SizeStr; i++)
{
    System.Console.WriteLine($"{str[i]} ");
} 