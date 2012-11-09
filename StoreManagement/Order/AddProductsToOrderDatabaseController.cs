﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManagement
{
    public static class AddProductsBuffer
    {
        public static string productName;
        public static int productQuantity;
        public static List<string> products = new List<string>();
        public static List<int> price = new List<int>();
    }
    partial class OracleDatabaseController
    {
        private Boolean exists()
        {
            Boolean foo = select("*", "ORDER_" + OrdersBuffer.id.ToString(), "PRODUCT_NAME='" + AddProductsBuffer.productName + "'");
            connection.Close();
            return foo;
        }
        public void loadPrice()
        {
            select("*", "PRODUCTS");
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    AddProductsBuffer.products.Add(reader["PRODUCT_NAME"].ToString());
                    AddProductsBuffer.price.Add(int.Parse(reader["RETAIL_COST"].ToString()));
                }
            }
            connection.Close();
        }
        public void addToTheGrid()
        {
            int i;
            for( i = 0 ; i < AddProductsBuffer.products.Count ; i++)
            {
                if(AddProductsBuffer.productName == AddProductsBuffer.products[i])
                    break;
            }
            if (exists())
            {
                if (AddProductsBuffer.productQuantity == 0)
                {
                    delete("ORDER_" + OrdersBuffer.id.ToString(), "PRODUCT_NAME='" + AddProductsBuffer.productName + "'");
                }
                else
                {
                    update("ORDER_" + OrdersBuffer.id.ToString(), "QUANTITY='" + AddProductsBuffer.productQuantity.ToString() + "',PRICE='"+(AddProductsBuffer.productQuantity * AddProductsBuffer.price[i]).ToString()+"'", "PRODUCT_NAME='" + AddProductsBuffer.productName + "'");
                }
                connection.Close();
            }
            else
            {
                insert("ORDER_" + OrdersBuffer.id.ToString(), "PRODUCT_NAME,QUANTITY,PRICE", "'"
                    + AddProductsBuffer.productName + "','" + AddProductsBuffer.productQuantity.ToString() + "','"+(AddProductsBuffer.productQuantity * AddProductsBuffer.price[i]).ToString()+"'");
                connection.Close();
            }
        }
        public List<string> getComboBoxProducts()
        {
            return getStringListForColumnFromTable("PRODUCTS", "PRODUCT_NAME");
        }
    }
}
