namespace Ex03.MinionNames
{
    public class SqlQueries
    {
        public static string GetVillainById = @"SELECT [Name] FROM Villains WHERE Id = @id";

        public static string GetMinionsByVillainId = @"SELECT ROW_NUMBER() OVER (ORDER BY m.[Name]) AS RowNum, m.[Name], m.[Age] FROM MinionsVillains AS mv JOIN Minions AS m ON mv.MinionId = m.Id WHERE mv.VillainId = @id ORDER BY m.[Name] ASC";
    }
}
