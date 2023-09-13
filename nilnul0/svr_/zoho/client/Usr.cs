using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.svr_.zoho.client
{

	class Usr
	{
		public const string Scope = "AaaServer.profile.UPDATE,AaaServer.profile.Read,ZohoCalendar.calendar.ALL";

		static public string Scope1 { get {
				return Scope.Replace(",", "%2C");
			} }
	}
}
