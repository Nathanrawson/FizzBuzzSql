using FizzBuzz.Interfaces;
using System.Data.SqlClient;
using System.Data;

public class FizzBuzzData : IFizzBuzzData
{
    private readonly string _connectionString;

    public FizzBuzzData(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void StoreResult(int id, string result)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            using (SqlCommand command = new SqlCommand("StoreFizzBuzzResult", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id", id));
                command.Parameters.Add(new SqlParameter("@Result", result));

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}