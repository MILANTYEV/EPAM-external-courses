using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entities;

namespace Data
{
    public class PrizesSqlDAO : IPrizeDAO, IDisposable
    {
        private SqlConnection _connection;

        public PrizesSqlDAO()
        {
            InitConnection();
        }

        private void InitConnection()
        {
            _connection = new SqlConnection(DBConfig.GetConnectionString());
            _connection.Open();
            _connection.StateChange += ConnectionStateChange;
        }

        private void ConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (e.CurrentState == ConnectionState.Broken)
            {
                InitConnection();
            }
        }

        public IEnumerable<Prize> GetPrizeList()
        {
            List<Prize> prizes = new List<Prize>();
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Prizes";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string title = (string)reader["Title"];
                    string description = (string)reader["Description"];
                    prizes.Add(new Prize(id, title, description));
                }
                reader.Close();
            }
            return prizes;
        }

        public void AddPrize(Prize prize)
        {
            if (prize == null)
            {
                throw new ArgumentException("Null prize");
            }
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Prizes VALUES (@ID, @Title, @Description)";
                command.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 100));
                command.Parameters.Add(new SqlParameter("@Title", SqlDbType.NVarChar, 50));
                command.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 250));
                command.Prepare();
                command.Parameters[0].Value = prize.ID;
                command.Parameters[1].Value = prize.Title;
                command.Parameters[2].Value = prize.Description;
                var res = command.ExecuteNonQuery();
            }
        }

        public void DeletePrize(Prize prize)
        {
            if (prize == null)
            {
                throw new ArgumentException("null user");
            }
            using (SqlCommand delRewardingComand = _connection.CreateCommand())
            {
                delRewardingComand.CommandText = "DELETE FROM Rewarding WHERE PrizeID = @przID";
                delRewardingComand.Parameters.Add(new SqlParameter("@przID", SqlDbType.Int));
                delRewardingComand.Prepare();
                delRewardingComand.Parameters[0].Value = prize.ID;
                var res = delRewardingComand.ExecuteNonQuery();
            }
            using (SqlCommand delPrizeCommand = _connection.CreateCommand())
            {
                delPrizeCommand.CommandText = "DELETE FROM Prizes WHERE ID = @id";
                delPrizeCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                delPrizeCommand.Prepare();
                delPrizeCommand.Parameters[0].Value = prize.ID;
                var result = delPrizeCommand.ExecuteNonQuery();
            }
        }

        public void ChangePrize(Prize oldPrize, Prize newPrize)
        {
            if (oldPrize == null || newPrize == null)
            {
                throw new ArgumentException("null prize");
            }
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "UPDATE Prizes Set Title = @title, Description = @description "+
                                        "WHERE ID = @id";
                command.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar, 50));
                command.Parameters.Add(new SqlParameter("@description", SqlDbType.NVarChar, 250));
                command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 100));
                command.Prepare();
                command.Parameters[0].Value = newPrize.Title;
                command.Parameters[1].Value = newPrize.Description;
                command.Parameters[2].Value = oldPrize.ID;
                var res = command.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
            }
        }
    }
}
