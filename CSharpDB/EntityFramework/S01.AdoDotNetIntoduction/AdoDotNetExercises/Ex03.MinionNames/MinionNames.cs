using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;

namespace Ex03.MinionNames
{
    internal class MinionNames
    {
        static string sqlConnectionString = "Server=DESKTOP-984QGPC;Database=MinionsDB;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True";
        static SqlConnection? sqlConnection;


        static async Task Main(string[] args)
        {
            int villainId = int.Parse(Console.ReadLine());

            try
            {
                sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();

                await GetMinionsByVillainId(villainId);
            }
            finally
            {
                sqlConnection?.Dispose();
            }
        }

        static async Task GetMinionsByVillainId(int id)
        {
            using SqlCommand cmd = new SqlCommand(SqlQueries.GetVillainById, sqlConnection);
            cmd.Parameters.AddWithValue("@id", id);
            var result = await cmd.ExecuteScalarAsync();

            if (result == null)
            {
                Console.WriteLine($"No villain with ID {id} exists in the database.");
            }
            else
            {
                Console.WriteLine($"Villain: {result.ToString()}");

                await Console.Out.WriteLineAsync(result.ToString());

                using SqlCommand cmd2 = new SqlCommand(SqlQueries.GetMinionsByVillainId, sqlConnection);
                cmd2.Parameters.AddWithValue("@id", id);
                result = await cmd2.ExecuteScalarAsync();



                if (result == null)
                {
                    Console.WriteLine($"(no minions)");
                }
                else
                {
                    SqlDataReader sqlDataReader = await cmd2.ExecuteReaderAsync();
                    while (await sqlDataReader.ReadAsync())
                    {
                        Console.WriteLine($"{sqlDataReader[0]}. {sqlDataReader[1]} {sqlDataReader[2]}");
                    }
                }

            }

        }
    }
}