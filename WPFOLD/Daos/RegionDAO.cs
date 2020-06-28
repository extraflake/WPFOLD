using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFOLD.Context;
using WPFOLD.Daos.IDaos;
using WPFOLD.Models;

namespace WPFOLD.Daos
{
    class RegionDAO : IRegionDAO
    {
        protected MySqlConnection mySqlConnection;

        public RegionDAO()
        {
            mySqlConnection = Connection.GetConnection();
        }

        public List<Region> Get()
        {
            List<Region> regions = new List<Region>();
            string query = @"SELECT * FROM region";
            try
            {
                MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
                mySqlConnection.Open();
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Region region = new Region()
                    {
                        Id = sqlDataReader.GetInt32(0),
                        Name = sqlDataReader.GetString(1)
                    };
                    regions.Add(region);
                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
            }
            
            return regions;
        }

        public bool Insert(Region region)
        {
            string query = @"INSERT INTO region (Name) VALUES (@Name)";
            try
            {
                MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlParameter sqlParameter = new MySqlParameter()
                {
                    ParameterName = "@Name",
                    MySqlDbType = MySqlDbType.VarChar,
                    Value = region.Name
                };
                sqlCommand.Parameters.Add(sqlParameter);
                mySqlConnection.Open();
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException);
            }
            return true;
        }
    }
}
