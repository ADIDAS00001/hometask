void MinMaxDigit(int n)
{
    int mn=Convert.ToInt32(999999);
    int mx=Convert.ToInt32(-99999);
    for(int i=n;i>0;i/=10)
    {
        if(i%10>mx)
        {
            mx=i%10;
        }
        if(i%10<mn)
        {
            mn=i%10;
        }
    }
    System.Console.WriteLine($"{mn} + {mx} = {mn+mx}");
}
MinMaxDigit(1234);