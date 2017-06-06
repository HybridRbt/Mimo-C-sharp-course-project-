using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialMission
{
    class MyFirstApp
    {
        public static void Main(string[] args)
        {
            // Chapter 1
            var string_1 = "Agent ";
            var string_2 = "Smith";
            var character = string_1 + string_2;
            Console.WriteLine(character);

            var plansDefeated = 0;
            plansDefeated += 5;
            plansDefeated++;
            Console.WriteLine("Plans defeated: " + plansDefeated);

            int[] anArray = { 10, 2, 5, 4, 9 };
            var aList = new List<int>(anArray);
            aList.Sort();
            aList.Insert(0, 27);
            aList.Add(201);
            var listString = string.Join(", ", aList);
            Console.WriteLine(listString);

            var aDic = new Dictionary<string, int>()
            {
                {"jetpack", 1},
                {"pager", 2},
                {"pen gun", 5},
                {"tape recorder", 2},
                {"tracking device", 3}
            };
            var dicString = string.Join("\n", aDic);
            Console.WriteLine(dicString);

            var missionList = new List<string>()
            {
                "defeat weapons dealer",
                "investigate hijacking",
                "uncover jewel smuggler"
            };

            foreach (var mission in missionList)
            {
                Console.WriteLine("Completed: " + mission);
                //missionList.Remove(mission);
            }

            missionList.Clear();
            Console.WriteLine(missionList.Count);
        }
    }
}