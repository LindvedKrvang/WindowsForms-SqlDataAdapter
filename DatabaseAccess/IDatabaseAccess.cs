using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public interface IDatabaseAccess
    {
        /// <summary>
        /// Calls the associated database and returns a DataSet between two tables containing a DataRelation between them.
        /// </summary>
        /// <returns>A DataSet with a DataRelationen between them.</returns>
        DataSet GetData();

        /// <summary>
        /// Calls the associated database with a DataSet. The DataSet is then commiting all of its changes to the database.
        /// </summary>
        /// <param name="dataSet">The DataSet containing the changes to be committed.</param>
        void CommitData(DataSet dataSet);
    }
}
