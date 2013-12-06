#DFP API DotNet Client Library

##Introduction
Google's DoubleClick for Publishers (DFP) API service lets developers design computer programs that interact directly with the DFP platform. With these applications, advertisers and third parties can more efficiently and creatively manage their large or complex DFP accounts.

The DFP API DotNet Client Library makes it easier to write .NET clients to programmatically access DFP accounts. All client library classes and utilities are in the `Google.Api.Ads.Dfp` namespace or sub-namespaces. The library is compatible with .NET SDK 2.0 and above. When using the library, you needn't worry about downloading WSDLs and such, since the library contains stub classes for all the supported services and takes care of details like SOAP marshalling and unmarshalling, SOAP logging, etc. The complete documentation for the DFP API is available from https://developers.google.com/doubleclick-publishers/docs/start.

##Features

- Support for .NET SDK 2.0 and above.
- Outgoing and incoming SOAP messages are monitored and logged.
- Support for API calls to test, beta or production environments.
- As opposed to autogenerated stubs from wsdl.exe, you don't have to specify `xxxSpecified = true` for each nullable property.
- Support for specific DFA exceptions instead of generic SoapExceptions.

##Downloading the client library

###Nuget

The DFA API DotNet Client Library and code examples are hosted on nuget.org as Nuget packages. The package details are given below:

- [Google.Dfp](https://www.nuget.org/packages/Google.Dfp/): DFP API DotNet Client Library
- [Google.Dfp.Examples.CSharp](https://www.nuget.org/packages/Google.Dfp.Examples.CSharp/): C# Code examples for DFP API.

###Precompiled binary and source distributions.

You can download precompiled binary and source distributions from the [releases page](../../releases/latest).

###Download the repository contents

If you want to download the contents of the repository, you can do it using the command

```
git clone https://github.com/googleads/googleads-dfp-dotnet-lib
```

##How do I use the library?

You can refer to the [README](../../wiki/README) wiki article to get more details on how to start using the library. We have code examples for most of the common use cases in the [repository](examples). These code examples are also available as part of the [precompiled binary and source distributions](../../releases/latest). You can also refer to the [wiki](../../wiki) articles for additional documentation.

##Where do I report issues?

Please report issues on the [issues page](../../issues).

##Support forum:

If you have questions about the client library or DFP API, you can ask them at http://groups.google.com/group/google-doubleclick-for-publishers-api/

##How do I contribute?

See [this wiki article](../../wiki/Becoming-a-contributor) for details.

##Requirements

  - .NET Framework 2.0 (or above): http://msdn2.microsoft.com/en-us/netframework/default.aspx
  - Visual Studio: http://msdn2.microsoft.com/en-us/vstudio/default.aspx
  - DFP Account: See https://developers.google.com/doubleclick-publishers/docs/start if you don't have one yet.


##Authors
  - api.anash@gmail.com (Anash P. Oommen)
  - thagikura@google.com (Takeshi Hagikura)
