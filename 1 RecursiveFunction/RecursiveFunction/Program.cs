using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFunction
{
    class Program
    {
        public static int count = 0;
        public static List<Area> area = new List<Area>();
        public  static int? emptyParent = null;
        public static List<string> newArea = new List<string>();

        static void Main(string[] args)
        {
            area.Add(new Area { Id = 1, Description = "Continent", Parent = null });
            area.Add(new Area { Id = 2, Description = "Country", Parent = 1 });
            area.Add(new Area { Id = 3, Description = "Province", Parent = 2});
            area.Add(new Area { Id = 4, Description = "City1", Parent = 3 });
            area.Add(new Area { Id = 5, Description = "Suburb1", Parent = 6 });
            area.Add(new Area { Id = 6, Description = "City2", Parent = 3 });
            area.Add(new Area { Id = 7, Description = "Suburb2", Parent = 6 });
            area.Add(new Area { Id = 8, Description = "Suburb3", Parent = 6 });
            area.Add(new Area { Id = 9, Description = "Suburb4", Parent = 4 });
            area.Add(new Area { Id = 10, Description = "House1", Parent = 7 });
            area.Add(new Area { Id = 11, Description = "House2", Parent = 9 });
            area.Add(new Area { Id = 12, Description = "House3", Parent = 8 });
            area.Add(new Area { Id = 13, Description = "House4", Parent = 8 });
            area.Add(new Area { Id = 14, Description = "House5", Parent = 7 });

            SortFunction(emptyParent);

            foreach (var item in newArea)
            {
                Console.WriteLine(item);
            }
        }

        public static void SortFunction(int?parent)
        {
            List<Area> items = new List<Area>();
            for (int i = 0; i < area.Count; i++)
            {
                if (area[i].Parent == parent)
                {
                    items.Add(area[i]);
                }
            }

            for (int j = 0; j < items.Count; j++)
            {
                string intro = "";
                for (int k = 0; k < count; k++)
                {
                    intro = intro + "--" + items[j].Description;
                }
                newArea.Add(intro);

                count++;
                SortFunction(items[j].Id);
                count--;
            }
        }
    }
}
