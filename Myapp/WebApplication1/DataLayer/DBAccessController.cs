﻿using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DataLayer
{
    public class DBAccessController : DBConnection
    {
        public DataTable RetriveAllRecords(string storedProcedureName)
        {
            var dt = new DataTable();
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand(storedProcedureName, con) { CommandType = CommandType.StoredProcedure };
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                return dt;
            }
            catch (System.Exception)
            {      
                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public DataTable RetriveRecordsWithPara(string storedProcedureName, Dictionary<string, object> param)
        {
            var dt = new DataTable();
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand(storedProcedureName, con) { CommandType = CommandType.StoredProcedure };
                foreach (var item in param)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                return dt;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public bool InsertRecord(string storedProcedureName,Dictionary<string, object> dataset)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand(storedProcedureName, con) { CommandType = CommandType.StoredProcedure };

                foreach (var item in dataset)
                {
                    cmd.Parameters.AddWithValue(item.Key,item.Value);
                }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (System.Exception)
            {
                
                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public bool DeleteRecord(string storedProcedureName, Dictionary<string, object> param) 
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand(storedProcedureName, con) { CommandType = CommandType.StoredProcedure };

                foreach (var item in param)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public bool UpdateRecord(string storedProcedureName, Dictionary<string, object> param)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand(storedProcedureName, con) { CommandType = CommandType.StoredProcedure };

                foreach (var item in param)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public int InsertRecordGetId(string storedProcedureName, Dictionary<string, object> dataset,string returnParam)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand(storedProcedureName, con) { CommandType = CommandType.StoredProcedure };

                foreach (var item in dataset)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                SqlParameter retval = cmd.Parameters.Add(returnParam, SqlDbType.Int);
                retval.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();

                int returnValue = (int)cmd.Parameters[returnParam].Value;

                return returnValue;
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
