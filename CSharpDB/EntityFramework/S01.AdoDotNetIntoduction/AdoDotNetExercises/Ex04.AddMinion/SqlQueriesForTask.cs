namespace Ex04.AddMinion
{
    internal class SqlQueriesForTask
    {
        public const string GetVillainId = @"SELECT Id FROM Villains WHERE Name = @Name";

        public const string GetMinionId = @"SELECT Id FROM Minions WHERE [Name] = @name AND Age = @age AND TownId = @townId";

        public const string AddMinionAndVillainConnection = @"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@minionId, @villainId)";

        public const string AddVillain = @"INSERT INTO Villains (Name, EvilnessFactorId) OUTPUT inserted.Id VALUES (@villainName, 4)";

        public const string AddMinion = @"INSERT INTO Minions (Name, Age, TownId) VALUES (@name, @age, @townId)";
        
        public const string AddTown = @"INSERT INTO Towns ([Name]) OUTPUT inserted.Id VALUES (@townName)";

        public const string GetTownId = @"SELECT Id FROM Towns WHERE Name = @townName";

    }
}
