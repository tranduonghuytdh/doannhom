using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class StatusOrderDao
    {
        Coffee_Master db = null;
        public StatusOrderDao()
        {
            db = new Coffee_Master();
        }
        public List<Status> ListAll()
        {
            return db.Status.Where(x => x.Status1 == true).OrderBy(x => x.Name).ToList();
        }
    }
}
