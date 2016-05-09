# IceWarp.Net
A .net wrapper for the IceWarp API

IceWarp.Net fully implements the [IceWarp API RPC](https://www.icewarp.co.uk/api/) calls.

## NuGet

```bash
PM> Install-Package IceWarp.Net
```

## Usage
	string apiUrl = "http://localhost/icewarpapi/";
	var api = new IceWarpRpcApi();
	Authenticate authenticate = new Authenticate
	{
		AuthType = TAuthType.Plain,
		Digest = "",
		Email = "admin@email.com",
		Password = "password",
		PersistentLogin = false
	};
	SuccessResponse authResult = api.Execute(apiUrl, authenticate);
	
	GetSessionInfo sessionInfo = new GetSessionInfo
	{
		SessionId = authResult.SessionId
	};
	TAPISessionInfoResponse sessionInfoResult = api.Execute(apiUrl, sessionInfo);
	
	Logout logout = new Logout
	{
		SessionId = authResult.SessionId
	};
	SuccessResponse logoutResult = api.Execute(apiUrl, logout);

## Com objects

Get Properties requests can be converted into objects similar to the Com Objects [IceWarp ServerAPI Reference](http://dl.icewarp.com/documentation/server/API/V%2011%20IceWarp%20Server%20API%20Reference.pdf).
```bash
GetAccountProperties
GetDomainProperties 
GetServerProperties
```