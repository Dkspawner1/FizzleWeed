using System.Runtime.InteropServices;
using System.Text.Json;

namespace FizzleWeed;

public class Weed : IWeed
{
    protected double ThcPerMg, CbdPerMg, TotalThc, TotalCbd;

    private readonly IWeed weed;
    public Weed() : base() => weed = this;

    public void AddEntry()
    {
        SelectEnumOption<IWeed.Categories>("Please Select Your Category");
        SelectEnumOption<IWeed.StrainType>("Please Select Your Strain");

    }

    private void SelectEnumOption<T>(string message) where T : Enum
    {
        var type = typeof(T);
        if (!type.IsEnum)
            throw new ArgumentException("T myst be an enumerated type");

        bool valid = false;
        int select = 0;
        do
        {
            //
            Console.WriteLine(message);
            IWeed test = new Weed();
            int selectCount = 0;

            test.PrintEnumValues(ref type, ref selectCount);
            //

            Console.WriteLine(selectCount);
            valid = int.TryParse(Console.ReadLine(), out select);
            if (select < 0 || select >= selectCount)
                valid = false;


        } while (!valid);


    }

}