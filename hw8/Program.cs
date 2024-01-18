
void MinNumber(int a, int b, int c, int d)
{
    int mn=0;
    int mn1=0;
    mn= Math.Min (a,b);
    mn1=Math.Min (c,d);
    if(mn<mn1)
    {
        System.Console.WriteLine(mn);
    }
    else{
        System.Console.WriteLine(mn1);
    }
}
MinNumber(1,2,3,4);
