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

            var an_array = { 10, 2, 5, 4, 9 };
            var a_list = new List<int>(an_array);
            a_list.Sort();
            a_list.Insert(0, 27);
            a_list.Add(201);
            var list_string = String.Join(", ", a_list);
            Console.WriteLine(a_list);
        }
    }
}