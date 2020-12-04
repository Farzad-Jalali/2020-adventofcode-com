using System;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode.Apps.day1
{
    public class Day1
    {
        public async Task<int[]> GetInput(string url)
        {
            // var client = new HttpClient();
            // var Content = (await client.GetAsync(url)).Content;
            // var ContentString = await Content.ReadAsStringAsync();
            var ContentString = @"1753
1976
1574
308
1384
1191
1731
1829
1658
1908
1663
2001
1298
1888
1134
1213
965
2009
1071
1591
1402
1184
1836
1536
1038
1871
1354
1149
1863
1728
1896
1599
1556
1222
1909
1858
1754
1947
1907
1656
1135
1845
1504
1473
1401
1700
1067
1790
1783
1539
1087
1614
1856
1895
1564
1106
1204
1492
1361
1897
1977
1210
1867
1797
1232
1148
1520
1989
210
1259
570
1512
1894
1309
1154
1327
1817
1875
1702
1885
1664
1220
1208
2000
1178
1423
1454
1780
1710
1362
1816
1491
1363
1478
1648
1163
1554
1195
1500
1320
1698
1636
1097
1573
1846
1747
1138
1083
1505
1387
1900
1143
1905
1826
1735
1496
1687
1704
1916
1991
1750
1637
1742
691
1967
1272
1657
1140
1070
1985
1405
1959
1218
1878
1340
1722
2003
1258
1726
1766
1868
1714
1463
2006
1537
1570
1526
1578
1744
1734
1325
196
1935
1849
1424
1972
1602
1859
1341
1177
1901
1902
1247
2004
1350
1965
1407
836
1899
1804
975
1510
1898
1560
1777
1523
1822
1830
1855
1839
1482
1661
1835
1343
1278
1449
1136
1732
2008
1686
1775
1952
1444
1499
1680
1752
1597
1963
1117
776";
            
            
            var lines = ContentString?.Split("\n", StringSplitOptions.RemoveEmptyEntries);

            int[] list  = lines.Select(int.Parse).ToArray();

            return list;
        }

        
        public void orchestrator()
        {
           var inputs =  GetInput(@"https://adventofcode.com/2020/day/1/input");

           var result = Answer(inputs.Result);
           
       //    Console.WriteLine($"first : {  result.first}  ,  second : {result.second} ");
           Console.WriteLine(result);
        }

        public long  Answer(int[] numbers)
        {
            int first = 0;
            int second = 0;
            int third = 0;
            
            for (int i = 0; i < numbers.Length - 3; i++)
            {
                first = numbers[i];
                for (int j = i + 1; j < numbers.Length-2; j++)
                {
                    second = numbers[j];

                    for (int k = j + 1; k < numbers.Length-1; k++)
                    {
                        third = numbers[k];

                        if (first + second + third == 2020)
                            return  first *  second * third;
                    
                    }
                    
                }
            }

            return 0;
        }
    }
}