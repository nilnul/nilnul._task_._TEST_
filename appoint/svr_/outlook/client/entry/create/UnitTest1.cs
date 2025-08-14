using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul._task_._TEST_.appoint.svr_.outlook.client.entry.create
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var scopes = new[] { "User.Read" };

			// Multi-tenant apps can use "common",
			// single-tenant apps must use the tenant ID from the Azure portal
			var tenantId = "common";

			// Value from app registration
			var clientId = "YOUR_CLIENT_ID";

			// using Azure.Identity;
			var options = new TokenCredentialOptions
			{
				AuthorityHost = AzureAuthorityHosts.AzurePublicCloud
			};

			// Callback function that receives the user prompt
			// Prompt contains the generated device code that use must
			// enter during the auth process in the browser
			Func<DeviceCodeInfo, CancellationToken, Task> callback = (code, cancellation) => {
				Console.WriteLine(code.Message);
				return Task.FromResult(0);
			};

			// https://docs.microsoft.com/dotnet/api/azure.identity.devicecodecredential
			var deviceCodeCredential = new DeviceCodeCredential(
				callback, tenantId, clientId, options);

			var graphClient = new GraphServiceClient(deviceCodeCredential, scopes);
		}
	}
}
