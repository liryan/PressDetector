using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Newtonsoft.Json;
using System.Data;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Common;
using System.Collections;

namespace PressDetector
{
    public class dbdriver
    {
        private SQLiteConnection dbConnection;
        DbTransaction dbTrans;
        public dbdriver(string strConn)
        {
            dbConnection = new SQLiteConnection(strConn);
            dbTrans = null;
            this.dbConnection.Open();
        }
        public void begin()
        {
            dbTrans = this.dbConnection.BeginTransaction();
        }
        public void end()
        {
            if (dbTrans != null)
            {
                dbTrans.Commit();
                dbTrans = null;
            }
        }
        public void rollback()
        {
            if (dbTrans != null)
            {
                dbTrans.Rollback();
            }
        }
        public ArrayList Query(string sql)
        {
            SQLiteCommand cmd = this.dbConnection.CreateCommand();
            cmd.CommandText = sql;
            SQLiteDataReader reader = cmd.ExecuteReader();
            ArrayList rows = new ArrayList();
            while (reader.Read())
            {
                Hashtable row = new Hashtable();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[reader.GetName(i)] = reader.GetValue(i);
                }
                rows.Add(row);
            }
            return rows;
        }

        public int update(String sql)
        {
            SQLiteCommand cmd = this.dbConnection.CreateCommand();
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        public void close()
        {
            this.dbConnection.Close();
        }
    }
}
