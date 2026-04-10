using System.Numerics;

namespace Blazor.Components.Pages
{
    public partial class Power
    {
        int num;
        int pow;
        BigInteger result;
        void Calculate()
        {
            result=(BigInteger)Math.Pow(num, pow);
        }
    }
}
