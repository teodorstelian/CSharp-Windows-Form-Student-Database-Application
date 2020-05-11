using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LoginForm
{
	public static class AppHelper
	{
		public static string ConnectionString => ConfigurationManager.ConnectionStrings["LoginForm.Properties.Settings.cn"].ConnectionString;
	}
}
