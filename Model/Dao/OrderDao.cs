using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.Dao
{
    public class OrderDao
    {
        Coffee_Master db = null;
        public OrderDao()
        {
            db = new Coffee_Master();
        }
        public long Insert(Order entity)
        {
            db.Orders.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public Order GetById(string userName)
        {
            return db.Orders.SingleOrDefault(x => x.ShipName == userName);
        }
        public Order ViewDetail(int id)
        {
            return db.Orders.Find(id);
        }
        public IEnumerable<Order> ListAllPaging(string seachString, int page, int pageSize)
        {
            IQueryable<Order> model = db.Orders;
            if (!string.IsNullOrEmpty(seachString))
            {
                model = model.Where(x => x.ShipName.Contains(seachString) || x.ShipName.Contains(seachString));
            }
            return model.OrderByDescending(x => x.CreateDate).ToPagedList(page, pageSize);
        }
        public bool Update(Order entity)
        {
            try
            {
                var user = db.Orders.Find(entity.ID);
                user.ShipName = entity.ShipName;
                user.ShipAddress = entity.ShipAddress;
                user.Email = entity.Email;
                user.ShipMoblie = entity.ShipMoblie;
                user.Status = entity.Status;
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var user = db.Orders.Find(id);
                db.Orders.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ChangeStatus(long id)
        {
            var user = db.Orders.Find(id);
            user.Status = !user.Status;
            db.SaveChanges();
            return user.Status;
        }
        public List<Order> ListAll()
        {
            return db.Orders.Where(x => x.Status == true).OrderBy(x => x.StatusOder).ToList();
        }
    }
}
