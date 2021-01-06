using shopping_basket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shopping_basket.ViewModel
{
    public class ProductIndexViewModel
    {
        //public IQueryable<Products> Products { get; set; }
        public PagedList.IPagedList<Products> Products { get; set; }
        public String Search { get; set; }
        public IEnumerable<CategoryWithCount> CategoryWithCounts { get; set; }
        public String Brand { get; set; }
        public string SortBy { get; set; }
        public Dictionary<string, string> Sorts { get; set; }
        public IEnumerable<SelectListItem> CatsFilterItem
        {
            get
            {
                var allCats = CategoryWithCounts.Select(c => new SelectListItem
                {
                    Value = c.CategoryName,
                    Text = c.CatNameWithCount
                });
                return allCats;
            }
        }
    }

    public class CategoryWithCount
    {
        public int ProductCount { get; set; }
        public String CategoryName { get; set; }
        public String CatNameWithCount
        {
            get
            {
                return CategoryName + "(" + ProductCount.ToString() + ")";
            }
        }
    }
}