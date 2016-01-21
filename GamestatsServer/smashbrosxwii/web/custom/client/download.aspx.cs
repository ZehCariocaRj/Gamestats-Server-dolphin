
namespace GamestatsServer
{
	using System;
	using System.Web;
	using System.Web.UI;

	public partial class download : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Request.QueryString.Count >= 2) {
				Response.Write ("");//TODO: Reverse the Response from the dumps and maybe the original game
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

