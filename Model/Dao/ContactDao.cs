using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
namespace Model.Dao
{
    public class ContactDao
    {
        Coffee_Master db = null;
        public ContactDao()
        {
            db = new Coffee_Master();
        }

        public Contect GetActiveContact()
        {
            return db.Contects.Single(x => x.Status == true);
        }

        public int InsertFeedBack(Feedback fb)
        {
            db.Feedbacks.Add(fb);
            db.SaveChanges();
            return (int)fb.ID;
        }
    }
}
