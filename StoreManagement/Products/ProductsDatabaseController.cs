﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManagement
{
    public static class ProductsBuffer
    {
        public static List<string> supplier_names = new List<string>();
        public static List<string> product_categories = new List<string>();
        public static int id;
        public static string product_name;
        public static string active_supplier_name;
        public static string active_product_catagory;
        public static int wholesale_cost;
        public static int retail_cost;

        public static void clearLists()
        {
            supplier_names.Clear();
            product_categories.Clear();
        }

        public static void flushBuffer()
        {
            id = wholesale_cost = retail_cost = 0;
            product_name = active_supplier_name = active_product_catagory;
        }
    }
    partial class OracleDatabaseController
    {
        public Boolean getAllSupplierRows()
        {
            try
            {
                select_distinct("SUPPLIER_NAME", "SUPPLIERS");
                if (!reader.HasRows)
                {
                    connection.Close();
                    return false;
                }
                while (reader.Read())
                {
                    ProductsBuffer.supplier_names.Add((string)reader["SUPPLIER_NAME"]);
                }
                connection.Close();
                return true;
            }
            catch (Oracle.DataAccess.Client.OracleException oe)
            {
                Console.WriteLine(oe);
                connection.Close();
                return false;
            }
        }

        public Boolean getAllProductCategoryRows()
        {
            try
            {
                select_distinct("PRODUCT_CATEGORY", "PRODUCT_CATEGORIES");
                if (!reader.HasRows)
                {
                    connection.Close();
                    return false;
                }
                while (reader.Read())
                {
                    ProductsBuffer.product_categories.Add((string)reader["PRODUCT_CATEGORY"]);
                }
                connection.Close();
                return true;
            }
            catch (Oracle.DataAccess.Client.OracleException oe)
            {
                Console.WriteLine(oe);
                connection.Close();
                return false;
            }
        }

        public void getNextMaxProductId()
        {
            selectMax("PRODUCT_ID", "ID", "PRODUCTS");
            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                    ProductsBuffer.id = 0;
                } 
                else
                {
                    ProductsBuffer.id = Convert.ToInt32(reader["ID"].ToString()) + 1;
                }
                
            }
            connection.Close();
        }

        public Boolean addProduct()
        {
            if (insert("PRODUCTS",
                "PRODUCT_ID,PRODUCT_NAME,SUPPLIER_NAME,PRODUCT_CATEGORY,WHOLESALE_COST,RETAIL_COST",
                "'" + ProductsBuffer.id + "','" + ProductsBuffer.product_name + "','" + ProductsBuffer.active_supplier_name +
                "','" + ProductsBuffer.active_product_catagory + "','" +
                ProductsBuffer.wholesale_cost + "','" + ProductsBuffer.retail_cost + "'") > 0)//if qurey returns int > 0
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean selectProduct()
        {
            return false;
        }

        public Boolean modifyProduct()
        {
            return false;
        }

        public Boolean deleteProduct()
        {
            return false;
        }
    }
}