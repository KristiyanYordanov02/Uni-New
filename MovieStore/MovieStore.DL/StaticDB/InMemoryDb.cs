using MovieStore.Models.DTO;

namespace MovieStore.DL.StaticDB
{
    internal static class InMemoryDb
    {
        internal static List<Actor> Actors
            = new List<Actor>
        {
            new Actor
            {
                Id = "1",
                Name = "Tim Robbins"
            },
            new Actor
            {
                Id = "2",
                Name = "Morgan Freeman"
            },
            new Actor
            {
                Id = "3",
                Name = "Marlon Brando"
            },
            new Actor
            {
                Id = "4",
                Name = "Al Pacino"
            },
            new Actor
            {
                Id = "5",
                Name = "Christian Bale"
            },
            new Actor
            {
                Id = "6",
                Name = "Heath Ledger"
            },
        };

    }
}