using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectedApplication.contracts
{
    public interface DatabaseDriver
    {

        bool Connect();
        List<T> Get<T>(string strQuerySql);
        bool Update(string strUpdateSql);
        void Disconnect();

    }
}
