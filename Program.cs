using System;
class Program
{
    static void Main()
    {
        Console.Write("numberOfCities: ");
        int numberOfCities = int.Parse(Console.ReadLine());

        Dictionary<int, string> cities = new Dictionary<int, string>();

        for (int i = 0; i < numberOfCities; i++)
        {
            Console.WriteLine(" city {0}", i);
            Console.Write(" cityName: ");
            string cityName = Console.ReadLine();

            Console.Write("umberOfConnections: ");
            int numberOfConnections = int.Parse(Console.ReadLine());

            Console.WriteLine("รายละเอียดเมืองที่ติดต่อกับเมืองนี้:");

            Dictionary<int, string> connections = new Dictionary<int, string>();

            for (int j = 0; j < numberOfConnections; j++)
            {
                Console.Write("หมายเลขประจำเมืองที่ {0}: ", j);
                int cityId = int.Parse(Console.ReadLine());

                if (connections.ContainsKey(cityId) || cityId >= numberOfCities || cityId == i)
                {
                    Console.WriteLine("Invalid ID");
                    j--;
                    continue;
                }

                Console.Write("ชื่อเมืองที่ {0}: ", cityId);
                string connectedCityName = Console.ReadLine();

                connections.Add(cityId, connectedCityName);
            }

            cities.Add(i, cityName);

            Console.WriteLine();
        }

        Console.WriteLine("ข้อมูลเมืองทั้งหมด:");
        foreach (var city in cities)
        {
            Console.WriteLine("เมืองที่ {0}: {1}", city.Key, city.Value);
            Console.WriteLine("เมืองที่ติดต่อกับเมืองนี้:");

            Dictionary<int, string> connections = cities[city.Key];
            foreach (var connection in connections)
            {
                Console.WriteLine("  เมืองที่ {0}: {1}", connection.Key, connection.Value);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

//ท้อแท้TWT