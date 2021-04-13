using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ProductCategoryDao
    {
        Coffee_Master db = null;
        public ProductCategoryDao()
        {
            db = new Coffee_Master();
        }
        public ProductCategory GetByID(long id)
        {
            return db.ProductCategories.Find(id);
        }
        public long Insert(ProductCategory entity)
        {
            db.ProductCategories.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        public IEnumerable<ProductCategory> ListAllPaging(string seachString, int page, int pageSize)
        {
            IQueryable<ProductCategory> model = db.ProductCategories;
            if (!string.IsNullOrEmpty(seachString))
            {
                model = model.Where(x => x.Name.Contains(seachString) || x.Name.Contains(seachString));
            }
            return model.OrderByDescending(x => x.CreateDate).ToPagedList(page, pageSize);
        }
        public ProductCategory ViewDetail(long id)
        {
            return db.ProductCategories.Find(id);
        }
        public bool Delete(int id)
        {
            try
            {
                var product = db.ProductCategories.Find(id);
                db.ProductCategories.Remove(product);
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
            var user = db.ProductCategories.Find(id);
            user.Status = !user.Status;
            db.SaveChanges();
            return user.Status;
        }
        public bool Update(ProductCategory entity)
        {
            try
            {
                var product = db.ProductCategories.Find(entity.ID);
                product.Name = entity.Name;
                product.MetaTitle = entity.MetaTitle;
                product.CreateDate = entity.CreateDate;
                product.DisplayOrder = entity.DisplayOrder;
                product.ParentID = entity.ParentID;
                product.ModifiedDate = entity.ModifiedDate;
                product.SeoTitle = entity.SeoTitle;
                product.Status = entity.Status;
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<ProductCategory> ListAll()
        {
            return db.ProductCategories.Where(x => x.Status == true).OrderBy(x => x.DisplayOrder).ToList();
        }
    }
}
