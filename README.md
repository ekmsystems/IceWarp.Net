# IceWarp.Net
A .net wrapper for the IceWarp API

IceWarp.Net fully implements the [IceWarp API RPC](https://www.icewarp.co.uk/api/) calls.

## NuGet

```Powershell
Install-Package IceWarp.Net
```

## Usage
```cs
var apiUrl = "http://localhost/icewarpapi/";
var api = new IceWarpRpcApi();
var authenticate = new Authenticate
{
	AuthType = TAuthType.Plain,
	Digest = "",
	Email = "admin@email.com",
	Password = "password",
	PersistentLogin = false
};
var authResult = api.Execute(apiUrl, authenticate);

var sessionInfo = new GetSessionInfo
{
	SessionId = authResult.SessionId
};
var sessionInfoResult = api.Execute(apiUrl, sessionInfo);

var logout = new Logout
{
	SessionId = authResult.SessionId
};
var logoutResult = api.Execute(apiUrl, logout);
```
## Com objects

Get Properties requests can be converted into objects similar to the Com Objects installed on the server.

[IceWarp ServerAPI Reference](http://dl.icewarp.com/documentation/server/API/V%2011%20IceWarp%20Server%20API%20Reference.pdf).

### Domain Properties

Create a Domain object from a GetDomainProperties request.

```cs
var getPropertiesRequest = new GetDomainProperties
{
	SessionId = "session id",
	DomainStr = "testing.co.uk",
	DomainPropertyList = new TDomainPropertyList
	{
		Items = ClassHelper.PublicProperites(typeof(Domain)).Select(x => x.Name).ToList()
	}
};
var getPropertiesResult = api.Execute(apiUrl, getPropertiesRequest);
var domain = new Domain(getPropertiesResult.Items);
```

Create a SetDomainProperties request from a Domain object.

```cs
var domain = new Domain
{
	D_Description = "description",
	D_AdminEmail = "admin@email.com"
};
var propertyValues = domain.BuildTPropertyValues();
var setPropertiesRequest = new SetDomainProperties
{
	SessionId = "session id",
	DomainStr = "testing.co.uk",
	PropertyValueList = new TPropertyValueList
	{
		Items = propertyValues
	}
};
```

Create a SetDomainProperties request from specific properties of a Domain object.

```cs
var domain = new Domain
{
	D_Description = "description",
	D_AdminEmail = "admin@email.com"
};
var propertyValues = domain.BuildTPropertyValues(new List<string> { "D_Description" });
var setPropertiesRequest = new SetDomainProperties
{
	SessionId = "session id",
	DomainStr = "testing.co.uk",
	PropertyValueList = new TPropertyValueList
	{
		Items = propertyValues
	}
};
```

### Account Properties

### Server Properties
