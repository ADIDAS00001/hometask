
void Max(int val1, int val2)
{
    int mx=0,mx1=0;
    mx=Math.Max(val1,val2);
    mx1=Math.Max(val1,val2);
    if(mx<mx1)
    {
        System.Console.WriteLine(mx); 
    }
    else 
    {
        System.Console.WriteLine(mx1);
    }
}
Max(2,1);