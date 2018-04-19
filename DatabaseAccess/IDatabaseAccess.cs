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
        /// <returns>A DataSet with a DataRelationen between them</returns>
        DataSet GetData();
    }
}
