using System.Collections.Specialized;
using System.Collections;

// 3 задание
Dictionary<int, double> enterpriseBalance = new Dictionary<int, double>
    {
        {123934, 23.94 },
        {2344474, 485.232 }
    };
Dictionary<int, double> enterpriseBalance2 = new Dictionary<int, double>();

void AddData()
{
    enterpriseBalance2.Add(2345, 949494.23);
    enterpriseBalance2.Add(68694, 2393.20449);
}

SortedDictionary<int, double> sortedEnterpriseBalance = new SortedDictionary<int, double>();
sortedEnterpriseBalance.Add(0, 20);
sortedEnterpriseBalance.Add(2332, 212.3);
//

// 4 задание

OrderedDictionary accountBalances = new OrderedDictionary();

accountBalances.Add(2311234, 220.94);
accountBalances.Add(5484, 4524);

public class CustomComparer : IComparer
{
    public int Compare(object x, object y)
    {
        if (x is int keyX && y is int keyY)
        {
            return keyX.CompareTo(keyY);
        }
        else
        {
            throw new ArgumentException("Key must be int");
        }
    }
}

//


