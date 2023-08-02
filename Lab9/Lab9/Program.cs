using System.Text.Json;
using System.IO;

namespace Lab9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string json = File.ReadAllText("C:\\Users\\Student-36\\OneDrive\\Desktop\\Projects\\Lab9\\Lab9\\Lab9\\Data.json");
            Console.WriteLine(json);

            FeatureCollection featureCollection = JsonSerializer.Deserialize<FeatureCollection>(json);
            Console.WriteLine("Deserialize the json data");

            Location[] locations = featureCollection.features;
            Console.WriteLine(locations);
            Part1WithLINQ(locations);
            Part2WithLINQ(locations);
            Part3WithLINQ(locations);
            Part4WithLINQ(locations);
        }

        public static void Part1(Location[] items)
        {
            Dictionary<string, int> locationAppearances = new Dictionary<string, int>();
            for (int i = 0; i < items.Length; i++)
            {
                Location currentLocation = items[i];
                string neighborhood = currentLocation.properties.neighborhood;
                bool neighborhoodA1readyInDictionary = locationAppearances.ContainsKey(neighborhood);
                if (locationAppearances.ContainsKey(currentLocation.properties.neighborhood) == false)
                {
                    locationAppearances.Add(currentLocation.properties.neighborhood, i);
                }
                else
                {
                    int currentValue = locationAppearances.GetValueOrDefault(neighborhood);
                    int newValue = currentValue + 1;
                    locationAppearances[neighborhood] = newValue;
                }
            }
            foreach (var location in locationAppearances)
            {
                Console.WriteLine($"{location.Key}: {location.Value}");
            }
        }
        public static void Part1WithLINQ(Location[] items)
        {
            var neighborHoodQuery = from item in items
                                    group item by item.properties.neighborhood into grouped
                                    select new { Key = grouped.Key, Value = grouped.Count() };
            
            foreach (var location in neighborHoodQuery)
            {
                Console.WriteLine($"{location.Key}: {location.Value}");
            }
        }

        public static void Part2WithLINQ(Location[] items)
        {
            
            var neighborHoodQuery = from item in items
                                    where item.properties.neighborhood != " "
                                    //group item by item.properties.neighborhood into grouped
                                    select item;
                                    
            
            foreach (var location in neighborHoodQuery)
            {
                Console.WriteLine(location.properties.neighborhood);
                //Console.WriteLine($"{location.Key}: {location.ValueTask}");
                
            }
        }

        public static void Part3WithLINQ(Location[] items)
        {
            var neighborHoodQuery = from item in items
                                    where item.properties.neighborhood != " "
                                    select item;

            var distinctMethod = items
                                .Where(item => item.properties.neighborhood != " ")
                                .Select(item => item.properties.neighborhood)
                                .Distinct();

            foreach (string n in distinctMethod)
            {
                Console.WriteLine(n);
            }
        }

        public static void Part4WithLINQ(Location[] items)
        {
            var neighborHoodQuery = items
                                   .Where(item => item.properties.neighborhood != " ")
                                   .Select(item => item.properties.neighborhood)
                                   .Distinct();

            foreach (var neighborhood in neighborHoodQuery)
            {
                Console.WriteLine(neighborhood);
            }
        }

        public static void Part5WithLINQ(Location[] items)
        {

        }
    }
}