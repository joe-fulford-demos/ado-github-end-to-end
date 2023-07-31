namespace mega_project_api
{
    public class BadCode
    {
        public void UpdateDatabase(string somethingToUpdate)
        {
            var connection = new SqlConnection("Server=.;Database=master;Trusted_Connection=True;User Id=sa;Password=ABC!5$5556pO;");       
            var sql = $"UPDATE [dbo].[ExampleTable] SET [ExampleColumn] = {somethingToUpdate}";
            var command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
        } 
    }
}