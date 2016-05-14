using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data
{
    public class UsersSqlDAO : IUserDAO, IDisposable
    {
        private SqlConnection _connection;

        public UsersSqlDAO()
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

        public IEnumerable<User> GetUsersList()
        {
            List<User> users = new List<User>();
            SqlCommand command = new SqlCommand("SELECT * FROM Users", _connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["ID"];
                string firstName = (string)reader["FirstName"];
                string lastName = (string)reader["LastName"];
                DateTime birthDate = (DateTime)reader["BirthDate"];
                User user = new User(id, firstName, lastName, birthDate);
                users.Add(user);
            }
            reader.Close();
            command.Dispose();
            foreach (var user in users)
            {
                SqlCommand prizesComand = _connection.CreateCommand();
                prizesComand.CommandText = "SELECT Prizes.ID, Prizes.Title, Prizes.Description " +
                    "FROM Prizes INNER JOIN Rewarding ON Prizes.ID = Rewarding.PrizeID " +
                    "WHERE Rewarding.UserID = @usrID";
                prizesComand.Parameters.Add(new SqlParameter("@usrID", SqlDbType.Int));
                prizesComand.Prepare();
                prizesComand.Parameters[0].Value = user.ID;
                SqlDataReader prizeReader = prizesComand.ExecuteReader();
                while (prizeReader.Read())
                {
                    int prizeID = (int)prizeReader["ID"];
                    string title = (string)prizeReader["Title"];
                    string description = (string)prizeReader["Description"];
                    Prize prize = new Prize(prizeID, title, description);
                    user.AddPrize(prize);
                }
                prizeReader.Close();
                prizesComand.Dispose();
            }
            return users;
        }

        public void AddUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentException("Null user");
            }
            SqlCommand command = _connection.CreateCommand();
            command.CommandText = "INSERT INTO Users VALUES (@ID, @FirstName, @LastName, @BirthDate)";
            command.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 100));
            command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 50));
            command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 50));
            command.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.DateTime, 100));
            command.Prepare();
            command.Parameters[0].Value = user.ID;
            command.Parameters[1].Value = user.FirstName;
            command.Parameters[2].Value = user.LastName;
            command.Parameters[3].Value = user.BirthDate;
            var result = command.ExecuteNonQuery();
            command.Dispose();
            if (user.PrizesList.Count == 0)
            {
                return;
            }
            foreach (var prize in user.PrizesList)
            {
                int rewardingID = GetNewRewardingID();
                SqlCommand addPrizesCommand = _connection.CreateCommand();
                addPrizesCommand.CommandText = "INSERT INTO Rewarding VALUES(@id, @usrID, @przID)";
                addPrizesCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 100));
                addPrizesCommand.Parameters.Add(new SqlParameter("@usrID", SqlDbType.Int, 100));
                addPrizesCommand.Parameters.Add(new SqlParameter("@przID", SqlDbType.Int, 100));
                addPrizesCommand.Prepare();
                addPrizesCommand.Parameters[0].Value = rewardingID;
                addPrizesCommand.Parameters[1].Value = user.ID;
                addPrizesCommand.Parameters[2].Value = prize.ID;
                var res = addPrizesCommand.ExecuteNonQuery();
                addPrizesCommand.Dispose();
            }

        }

        private int GetNewRewardingID()
        {
            SqlCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT MAX(ID) AS 'ID' FROM Rewarding";
            SqlDataReader reader = command.ExecuteReader();
            int newID = 1;
            while (reader.Read())
            {
                newID = (int)reader["ID"];
            }
            reader.Close();
            command.Dispose();
            return newID + 1;
        }
        
        public void ChangeUser(User oldUser, User newUser)
        {
            if (oldUser == null || newUser == null)
            {
                throw new ArgumentException("null user");
            }
            DeleteUser(oldUser);
            AddUser(newUser);
        }

        public void DeleteUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentException("Null user");
            }
            using (SqlCommand delRewardingComand = _connection.CreateCommand())
            {
                delRewardingComand.CommandText = "DELETE FROM Rewarding WHERE UserID = @usrID";
                delRewardingComand.Parameters.Add(new SqlParameter("@usrID", SqlDbType.Int));
                delRewardingComand.Prepare();
                delRewardingComand.Parameters[0].Value = user.ID;
                var res = delRewardingComand.ExecuteNonQuery();
            }
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM Users WHERE ID = @id";
                command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                command.Prepare();
                command.Parameters[0].Value = user.ID;
                var result = command.ExecuteNonQuery();
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
