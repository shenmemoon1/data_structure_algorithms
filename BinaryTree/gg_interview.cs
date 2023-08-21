using System;
using System.Collections.Generic;
using System.Linq;

class Block
{
    public bool Gym { get; set; }
    public bool School { get; set; }
    public bool Store { get; set; }
}

class ApartmentLocation
{
    public int Index { get; set; }
    public int TotalDistance { get; set; }
}

class Program
{
    static int CalculateDistance(int block1, int block2)
    {
        return Math.Abs(block1 - block2);
    }

    static ApartmentLocation FindOptimalLocation(List<Block> blocks)
    {
        List<ApartmentLocation> validLocations = new List<ApartmentLocation>();

        for (int i = 0; i < blocks.Count; i++)
        {
            if (blocks[i].Gym && blocks[i].School && blocks[i].Store)
            {
                validLocations.Add(new ApartmentLocation
                {
                    Index = i,
                    TotalDistance = 0
                });
            }
            else if (!blocks[i].Gym)
            {
                int gymDistance = blocks.Where(b => b.Gym).Min(gymBlock => CalculateDistance(i, blocks.IndexOf(gymBlock)));
                int schoolDistance = blocks.Where(b => b.School).Min(schoolBlock => CalculateDistance(i, blocks.IndexOf(schoolBlock)));
                int storeDistance = blocks.Where(b => b.Store).Min(storeBlock => CalculateDistance(i, blocks.IndexOf(storeBlock)));

                validLocations.Add(new ApartmentLocation
                {
                    Index = i,
                    TotalDistance = gymDistance + schoolDistance + storeDistance
                });
            }
        }

        return validLocations.OrderBy(location => location.TotalDistance).FirstOrDefault();
    }

    static void Main(string[] args)
    {
        List<Block> blocks = new List<Block>
        {
            new Block { Gym = false, School = true, Store = false },
            new Block { Gym = true, School = true, Store = false },
            new Block { Gym = false, School = true, Store = false },
            new Block { Gym = false, School = true, Store = true }
        };

        ApartmentLocation optimalLocation = FindOptimalLocation(blocks);
        Console.WriteLine($"Optimal Apartment Location: Block {optimalLocation.Index}, Total Distance: {optimalLocation.TotalDistance}");
    }
}
