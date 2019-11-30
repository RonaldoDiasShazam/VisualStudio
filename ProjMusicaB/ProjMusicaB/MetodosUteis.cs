using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMusicaB
{
    class MetodosUteis
    {


        public string conectaDBMySql()
        {
            return "server = localhost; database = db_login;" +
                " uid = root; pwd =1234";
        }
    }
}
