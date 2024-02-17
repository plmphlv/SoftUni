using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;

namespace Ex01.VillainNames
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            const string sqlConnectionString = "Server=DESKTOP-984QGPC;Database=MinionsDB;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection sqlConnection = new SqlConnection(sqlConnectionString))
            {
                await sqlConnection.OpenAsync();

                string query = @"SELECT v.[Name], COUNT(mv.MinionId) AS Minions FROM Villains AS v JOIN MinionsVillains AS mv ON v.Id = mv.VillainId WHERE v.[Name] = @name GROUP BY v.[Name]";


                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@name", Console.ReadLine());
                    SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync(); //Holds the entire result of the SQL query and then returns it line by line

                    while (await sqlDataReader.ReadAsync())
                    {
                        string? columName1 = sqlDataReader[0].ToString();
                        string? columName2 = sqlDataReader[1].ToString();



                        Console.WriteLine($"{columName1} - {columName2}");
                    }
                }
            }
        }
    }
}