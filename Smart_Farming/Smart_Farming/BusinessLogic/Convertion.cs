using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection; // used to convert
using System.Data;

namespace Smart_Farming.BusinessLogic
{
    public class Convertion
    {
        // this class is used to convert a datatable to a list
        #region Convertion
        public List<T> ConvertDataTable<T>(DataTable table)
        {
            List<T> list = new List<T>();
            foreach (DataRow row in table.Rows)
            {
                T item = GetItem<T>(row);
                list.Add(item);
            }
            return list;
        } 

        private T GetItem<T>(DataRow row)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in row.Table.Columns)
            {
                foreach (PropertyInfo propertyInfo in temp.GetProperties())
                {
                    if (propertyInfo.Name == column.ColumnName)
                    {
                        propertyInfo.SetValue(obj, row[column.ColumnName], null);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return obj;
        }
        #endregion
    }
}
