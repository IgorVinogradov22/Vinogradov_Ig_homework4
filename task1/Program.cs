// Задача : Найти сумму чисел от 1 до А


int a = 852;

int var1 (int n)
{
    int []arr = new int [n+1];
    for (int i = 0; i <= n; i++)
    {
        arr[i] = i;
    }
int res = 0;
for (int i = 0; i <= n; i++)
{
    res += arr [i]; 
}
return res;
}

int var2 (int n)
{
    int res = 0;
    for (int i = 0; i<= n; i++)
    {
        res += i;
    }
    return res;
}    

int var3  (int n)
{
    
    return  (n * (n + 1))/2;
}

Console.WriteLine(var1(a));
Console.WriteLine(var2(a));
Console.WriteLine(var3(a));


