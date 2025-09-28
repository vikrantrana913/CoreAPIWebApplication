using Microsoft.Data.SqlClient;
using System.Data;

namespace CoreMVCWebAPI.Models
{
    public class EmployeeDbContext
    {
        private readonly string _connectionString;

        public EmployeeDbContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public List<EmployeeDbModel> GetEmployee()
        {
            List<EmployeeDbModel> employeeDbModels = new List<EmployeeDbModel>();
            SqlConnection con=new SqlConnection(_connectionString);
            SqlCommand cmd=new SqlCommand("GetEmployeeData", con);
            cmd.CommandType=CommandType.StoredProcedure;
            con.Open(); 
            SqlDataReader rdr=cmd.ExecuteReader();
            while(rdr.Read())
            {
                EmployeeDbModel employeeDbModel=new EmployeeDbModel();
                employeeDbModel.EmpId=Convert.ToInt32(rdr["EmpId"]);
                employeeDbModel.Name=rdr["Name"].ToString();
                employeeDbModel.Email=rdr["Email"].ToString();
                employeeDbModels.Add(employeeDbModel);
            }   
            return employeeDbModels;

        }



    }
}
