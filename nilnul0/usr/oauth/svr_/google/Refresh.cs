using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.usr.oauth.svr_.google
{

	/// <summary>
	/// There is currently a limit of 100 refresh tokens per Google Account per OAuth 2.0 client ID. If the limit is reached, creating a new refresh token automatically invalidates the oldest refresh token without warning. This limit does not apply to service accounts.
	/// </summary>
	/// <remarks>
	///There is also a larger limit on the total number of refresh tokens a user account or service account can have across all clients. Most normal users won't exceed this limit but a developer's account used to test an implementation might.
	/// </remarks>
	/// https://developers.google.com/identity/protocols/oauth2
	internal class Refresh
	{
	}
}
