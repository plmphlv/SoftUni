using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;

namespace Ex04.AddMinion
{
    internal class Program
    {
        static string sqlConnectionString = "Server=DESKTOP-984QGPC;Database=MinionsDB;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True";

        static SqlConnection? sqlConnection;

        static async Task Main(string[] args)
        {
            sqlConnection = new SqlConnection(sqlConnectionString);

            string minionInfoRaw = Console.ReadLine();
            string villainInfoRaw = Console.ReadLine();

            string minionInfo = minionInfoRaw.Substring(minionInfoRaw.IndexOf(':') + 1).Trim();
            string villainInfo = villainInfoRaw.Substring(villainInfoRaw.IndexOf(':') + 1).Trim();

            sqlConnection.Open();
            await AddMinion(minionInfo, villainInfo);
            sqlConnection.Close();
            sqlConnection.Dispose();

        }

        private static async Task AddMinion(string minionInfo, string villainInfo)
        {
            string[] minionParams = minionInfo.Split(" ");

            string minionName = minionParams[0];
            int minionAge = int.Parse(minionParams[1]);
            string minionTown = minionParams[2];


            #region Town
            using SqlCommand cmdGetTownId = new SqlCommand(SqlQueriesForTask.GetTownId, sqlConnection);
            cmdGetTownId.Parameters.AddWithValue("@townName", minionTown);
            var townResult = await cmdGetTownId.ExecuteScalarAsync();

            int townId = -1;
            if (townResult is null)
            {
                using SqlCommand createTown = new SqlCommand(SqlQueriesForTask.AddTown, sqlConnection);
                createTown.Parameters.AddWithValue("@townName", minionTown);
                townId = Convert.ToInt32(await createTown.ExecuteScalarAsync());
                await Console.Out.WriteLineAsync($"Town {minionTown} was added to the database.");
            }
            else
            {
                townId = (int)townResult;
            }

            #endregion

            #region Villain
            SqlCommand cmdGetVillain = new SqlCommand(SqlQueriesForTask.GetVillainId, sqlConnection);
            cmdGetVillain.Parameters.AddWithValue("@Name", villainInfo);
            var villainResult = await cmdGetVillain.ExecuteScalarAsync();

            int villainId = -1;
            if (villainResult is null)
            {
                SqlCommand cmdInsertNewVillain = new SqlCommand(SqlQueriesForTask.AddVillain, sqlConnection);
                cmdInsertNewVillain.Parameters.AddWithValue("@villainName", villainInfo);
                villainId = Convert.ToInt32(await cmdInsertNewVillain.ExecuteScalarAsync());
                await Console.Out.WriteLineAsync($"Villain {villainInfo} was added to the database.");
            }
            else
            {
                villainId = (int)villainResult;
            }
            #endregion

            #region Minion
            using SqlCommand cmdGetMinionId = new SqlCommand(SqlQueriesForTask.GetMinionId, sqlConnection);
            cmdGetMinionId.Parameters.AddWithValue("@name", minionName);
            cmdGetMinionId.Parameters.AddWithValue("@age", minionAge);
            cmdGetMinionId.Parameters.AddWithValue("@townId", townId);

            var minionResult = await cmdGetMinionId.ExecuteScalarAsync();

            int minionId = -1;

            if (minionResult is null)
            {
                using SqlCommand sqlInsertNewMinion = new SqlCommand(SqlQueriesForTask.AddMinion, sqlConnection);
                sqlInsertNewMinion.Parameters.AddWithValue("@name", minionName);
                sqlInsertNewMinion.Parameters.AddWithValue("@age", minionAge);
                sqlInsertNewMinion.Parameters.AddWithValue("@townId", townId);

                minionId = Convert.ToInt32(await sqlInsertNewMinion.ExecuteScalarAsync());

                await Console.Out.WriteLineAsync($"");
            }
            else
            {
                minionId = (int)minionResult;
            }
            #endregion

            #region MinionVillainConnection
            using SqlCommand cmdGetMinionVillainConnection = new SqlCommand(SqlQueriesForTask.AddMinionAndVillainConnection, sqlConnection);
            cmdGetMinionVillainConnection.Parameters.AddWithValue("@minionId", minionId);
            cmdGetMinionVillainConnection.Parameters.AddWithValue("@villainId", villainId);
            var minionVillainResult = await cmdGetMinionVillainConnection.ExecuteScalarAsync();
                await Console.Out.WriteLineAsync($"Successfully added {minionName} to be minion of {villainInfo}.");

            //if (minionVillainResult is null)
            //{
            //    using SqlCommand cmdAddMinionVillainConnection = new SqlCommand(SqlQueriesForTask.AddMinionAndVillainConnection, sqlConnection);
            //    cmdAddMinionVillainConnection.Parameters.AddWithValue("@minionId", minionId);
            //    cmdAddMinionVillainConnection.Parameters.AddWithValue("@villainId", villainId);
            //}
            //else
            //{
            //    await Console.Out.WriteLineAsync($"Minion {minionName} already works for {villainInfo}.");
            //}


            #endregion
        }
    }
}