using System.Collections;

namespace FizzleWeed;

interface IWeed
{

    public enum StrainType
    {
        Sativa,
        SativaDominant,
        Indica,
        IndicaDominant,
    }
    public enum Categories
    {
        Flower,
        InfusedFlower,
        PreRolls,
        InfusedPreRolls,
        // Vapes
        Vaporizers,
        VaporizersLiveResin,
        VaporizersHash,
        VaporizersDistillate,
        VaporizersShatter,
        Concentrates,
        Edibles,
        Tinctures,
        Topicals,
    }

    void PrintEnumValues(ref Type e, ref int optionCount)
    {

        if (e.IsEnum)
        {
            var names = e.GetEnumValues() as IList;
            optionCount = names.Count;
            for (int i = 0; i < optionCount; i++)
            {
                object? item = names[i];
                Console.WriteLine($"({i})-{item}");

            }
        }

        else
        {
            Console.WriteLine("Not An Enum");
        }
    }
}