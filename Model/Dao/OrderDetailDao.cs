using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class OrderDetailDao
    {
        Coffee_Master db = null;
        public OrderDetailDao()
        {
            db = new Coffee_Master();
        }
        public bool Insert(OderDetail detail)
        {
            try
            {
                db.OderDetails.Add(detail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }
    }
}
