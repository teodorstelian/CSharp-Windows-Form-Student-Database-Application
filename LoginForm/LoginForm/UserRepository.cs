using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace LoginForm
{
	public class UserRepository : IUserRepository
	{
		public async Task<bool> Insert(User user)
		{
			using(IDbConnection db = new SqlConnection(AppHelper.ConnectionString))
			{
				var result = await db.ExecuteAsync(LoginForm.Properties.Resources.InsertUser, new { UserName = user.UserName, Password = user.Password, Email = user.Email });
				
				return result > 0;
			}
		}
	}
}
