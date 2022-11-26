using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKhamSan.DAL
{
    public class BaseDAL
    {
        public ConnectDB cnDB;

        public BaseDAL()
        {
            cnDB = new ConnectDB();
        }
    }
}
