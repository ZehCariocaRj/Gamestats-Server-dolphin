
namespace GamestatsServer
{
	using System;
	using System.Web;
	using System.Web.UI;

	public partial class put2 : System.Web.UI.Page
	{
		//done15a5ff3d835a9e893af615959c78552ac0f02909
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Request.QueryString.Count >= 2) {
				Response.Write ("done15a5ff3d835a9e893af615959c78552ac0f02909");
				Response.End ();
			} else {
				Response.Write (GenerateRandom (32));
				Response.End ();
			}
		}
		public string GenerateRandom(int length)
		{
			string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
			string res = "";
			Random rnd = new Random();
			while (0 < length--)
				res += valid[rnd.Next(valid.Length)];
			return res;
		}
	}
}

