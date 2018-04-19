using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public class DatabaseAccessFacade
    {
        private static DatabaseAccessFacade Instance;

        public static DatabaseAccessFacade GetInstance()
        {
            return Instance ?? (Instance = new DatabaseAccessFacade());
        }

        public IDatabaseAccess Database { get; }

        private DatabaseAccessFacade()
        {
            Database = new BirdsDatabase();
        }
    }
}
