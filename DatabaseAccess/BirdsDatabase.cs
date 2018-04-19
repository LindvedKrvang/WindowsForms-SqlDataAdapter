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
    }
}
