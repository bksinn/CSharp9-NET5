using System;
namespace Packt.Shared
{
    public class Person : Object
    {
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public (string, int) GetFruit()
        {
            return ("Apples", 7);
        }
    }
}