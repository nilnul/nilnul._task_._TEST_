using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Net.Sockets;

// Copyright 2016 Google Inc.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.svr_.zoho.acc.refresh
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

				const string host = "zoho.com";
			var rsc =
				$"client_.self_.org:{host}"
			;
			var cred = nilnul.win.app_._CredManX.Ensure(rsc);

			var clientId = cred.UserName;

			///Scope Name: AaaServer.profile.UPDATE,AaaServer.profile.Read
			///This code for the above scope is valid for only 10 minutes
			

			/// get the token
			///
			
			var p = new zoho.Acc();
			// p.DoOAuthAsync(clientId, clientSecret);
			var refreshRsc = $"client_.self_.org.refresh:{host}";
			var refreshToken = nilnul.win.app_._CredManX.Ensure(refreshRsc);


			Debug.WriteLine(refreshToken);

			var token = p.refresh4tokenAsync_zoho(refreshToken.Password, "", clientId, cred.Password).Result;

			Debug.WriteLine(token);


			return;

			var redirUrl = $"http://{IPAddress.Loopback}:{12345}/";
			var listener = new HttpListener();

			listener.Prefixes.Add(redirUrl);

			listener.Start();





		}

		// ref http://stackoverflow.com/a/3978040
		public static int GetRandomUnusedPort()
		{
			var listener = new TcpListener(IPAddress.Loopback, 0);
			listener.Start();
			var port = ((IPEndPoint)listener.LocalEndpoint).Port;
			listener.Stop();
			return port;
		}


	}
}


