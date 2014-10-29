using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace MedApp.Web.Controls
{
    public class BsGrid
    {
        public IEnumerable Items;

        public object DataSource
        {
            get
            {
                return Items;
            }
            set
            {
                Items = value as IEnumerable;
            }
        }
        
        public object GetData()
        {
            return new GridModel(Items, Items.Cast<object>().Count());
        }

        public void ApplyOptions()
        {
            
        }

        public IList Sort_List<T>(string sortDirection, string sortExpression, IEnumerable<T> data)
        {
            var data_sorted = new List<T>();

            if (sortDirection == "Ascending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) ascending
                               select n).ToList();
            }
            else if (sortDirection == "Descending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) descending
                               select n).ToList();

            }

            return data_sorted;

        }

        public object GetDynamicSortProperty(object item, string propName)
        {
            //Use reflection to get order type
            return item.GetType().GetProperty(propName).GetValue(item, null);
        }
    }

    class GridModel
    {
        public object debug_message;

        public object error;

        public object filter_error;

        public object page_data;

        public object total_rows;

        public GridModel(IEnumerable items, int count)
        {
            debug_message = new List<object>();
            filter_error = new List<object>(); 
            page_data = items; 
            total_rows = count;
        }
    }
}