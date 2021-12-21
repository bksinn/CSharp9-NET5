﻿using System;
using Packt.Shared;

namespace PersonApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatusofZeusAtOlympia;
            Console.WriteLine(
                format: "{0} was born on {1:dddd, d MMMM yyyy}",
                arg0: bob.Name,
                arg1: bob.DateOfBirth);

            Console.WriteLine(
                format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
                arg0: bob.Name,
                arg1: bob.FavoriteAncientWonder,
                arg2: (int)bob.FavoriteAncientWonder);

            var alice = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };
            Console.WriteLine(
                format: "{0} was born on {1:dd MMM yy}",
                arg0: alice.Name,
                arg1: alice.DateOfBirth
            );

            Console.WriteLine(bob.GetFruit());
        }
    }
}