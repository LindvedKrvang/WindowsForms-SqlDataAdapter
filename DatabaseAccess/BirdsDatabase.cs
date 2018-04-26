using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedData;

namespace DatabaseAccess
{
    internal class BirdsDatabase : IDatabaseAccess
    {
        // Change 'localhost' to your Database Server if the database is not running locally. 
        private const string BirdsConnectionString = "Server=localhost;Database=Birds;Integrated Security=SSPI";

        private const string SqlErrorMessage = "The Database is fetching coffee. Try again later...";

        private const string NameStr = "Name";

        /// <summary>
        /// Returns all data from the 'Bird' and BirdsCount' table with a DataRealtion on the BirdID property.
        /// </summary>
        /// <returns>The DataSet with the DataRelation</returns>
        public DataSet GetData()
        {
            try
            {
                var sqlQuery = "SELECT * FROM Bird ORDER BY Name";
                var adapter = new SqlDataAdapter(sqlQuery, BirdsConnectionString);

                var dataSet = new DataSet();

                adapter.Fill(dataSet, SharedNames.Birds);

                sqlQuery = "SELECT * FROM BirdCount";

                adapter.SelectCommand.CommandText = sqlQuery;

                adapter.Fill(dataSet, SharedNames.BirdCounts);

                var birdRelation = new DataRelation(SharedNames.BirdRelation,
                    dataSet.Tables[SharedNames.Birds].Columns[SharedNames.BirdId],
                    dataSet.Tables[SharedNames.BirdCounts].Columns[SharedNames.BirdId]);

                dataSet.Relations.Add(birdRelation);

                return dataSet;
            }
            catch (SqlException ex)
            {
                throw new Exception(SqlErrorMessage, ex);
            }

        }

        /// <summary>
        /// Updates all the changes in the DataSet to the BirdsDatabase.
        /// </summary>
        /// <param name="dataSet">The DataSet containing the changes to be commited to the database</param>
        public void CommitData(DataSet dataSet)
        {
            var adapter = new SqlDataAdapter();

            // -----------------------------------------------------------------------

            var insertQuery = $"INSERT INTO Bird (Name) VALUES (@{NameStr})";

            adapter.InsertCommand = CreateCommand(insertQuery, BirdsConnectionString, 
                CreateParameter(NameStr, SqlDbType.NVarChar));

            // -----------------------------------------------------------------------

            var updateQuery = "UPDATE Bird " +
                              $"SET Name = @{NameStr} " +
                              $"WHERE {SharedNames.BirdId} = @{SharedNames.BirdId}";

            adapter.UpdateCommand = CreateCommand(updateQuery, BirdsConnectionString, 
                CreateParameter(NameStr, SqlDbType.NVarChar), 
                CreateParameter(SharedNames.BirdId, SqlDbType.BigInt));

            // -----------------------------------------------------------------------

            var deleteQuery = $"DELETE FROM Bird WHERE {SharedNames.BirdId} = @{SharedNames.BirdId}";

            adapter.DeleteCommand = CreateCommand(deleteQuery, BirdsConnectionString, 
                CreateParameter(SharedNames.BirdId, SqlDbType.Int));

            // -----------------------------------------------------------------------

            adapter.Update(dataSet, SharedNames.Birds);
        }

        /// <summary>
        /// Creates and returns a new SqlCommand.
        /// </summary>
        /// <param name="query">The query that the command should execute.</param>
        /// <param name="connection">The connectionString to the database the command is operating on.</param>
        /// <param name="parameters">An array of SqlParameter that contains all the parameters for the command.
        /// Is allowed to be zero if no parameters are required!</param>
        /// <returns>The SqlCommand.</returns>
        private SqlCommand CreateCommand(string query, string connection, params SqlParameter[] parameters)
        {
            var command = new SqlCommand(query, new SqlConnection(connection));
            foreach (var parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }
            return command;
        }

        /// <summary>
        /// Creates and returns a new SqlParameter.
        /// </summary>
        /// <param name="tableName">The name of the SqlTable the parameter is bound to.
        /// Must also be the name of the parameter in the QueryString without the '@'!</param>
        /// <param name="type">The SqlDbType that this parameter specifies.</param>
        /// <returns></returns>
        private SqlParameter CreateParameter(string tableName, SqlDbType type)
        {
            return new SqlParameter($"@{tableName}", type){ SourceColumn = tableName};
        }
    }
}
