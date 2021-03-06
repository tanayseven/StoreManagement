﻿/*
 *  This project is a simlpe implmentation of store management database
 *  Copyright (C) 2012  Tanay Virkant Prabhu Desai
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManagement
{
    public static class SuppliersBuffer
    {
        public static string name,phone,email;
        public static void flushBuffer()
        {
            name = phone = email = "";
        }
    }
    partial class OracleDatabaseController
    {
        public Boolean addSupplier()
        {
            if (insert("SUPPLIERS", "SUPPLIER_NAME,PHONE,EMAIL", "'"
                + SuppliersBuffer.name + "', '" + SuppliersBuffer.phone + "', '" + SuppliersBuffer.email + "'") > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public Boolean selectSupplier()
        {
            if (select("*", "SUPPLIERS", "SUPPLIER_NAME='" + SuppliersBuffer.name + "'"))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SuppliersBuffer.name = reader["SUPPLIER_NAME"].ToString();
                        SuppliersBuffer.phone = reader["PHONE"].ToString();
                        SuppliersBuffer.email = reader["EMAIL"].ToString();
                    }
                    connection.Close();
                    return true;
                }
                connection.Close();
                return false;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public Boolean modifySupplier()
        {
            if (update("SUPPLIERS",
                "SUPPLIER_NAME='" + SuppliersBuffer.name +
                "',PHONE='" + SuppliersBuffer.phone +
                "',EMAIL='" + SuppliersBuffer.email + "'", "SUPPLIER_NAME='" + SuppliersBuffer.name + "'")
                > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public Boolean deleteSupplier()
        {
            if (delete("SUPPLIERS","SUPPLIER_NAME='"+SuppliersBuffer.name+"'") > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
    }
}
