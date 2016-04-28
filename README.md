# IceWarp.Net
A .net wrapper for the IceWarp API

IceWarp.Net fully implements the [IceWarp API RPC](https://www.icewarp.co.uk/api/) calls.

## Usage
	var api = new IceWarpRpcApi();
	var authenticate = new Authenticate
	{
		AuthType = TAuthType.Plain,
		Digest = "",
		Email = "admin@email.com",
		Password = "password",
		PersistentLogin = false
	};
	var authResult = api.Execute("http://localhost/icewarpapi/", authenticate);
