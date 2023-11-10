// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using System.Xml.Serialization;
using Bunkum.Core;
using Bunkum.Core.Endpoints;
using Bunkum.Core.Responses;
using Bunkum.Listener.Protocol;
using Bunkum.Protocols.Http;

namespace Lantern.Endpoints.API;

public class ApiLoginEndpoints : EndpointGroup
{
    [ApiEndpoint("eula")]
    public static string Eula(RequestContext context) => "eula";

    [ApiEndpoint("announce")]
    public static string Announcements(RequestContext context) => "announce";

    [ApiEndpoint("login", HttpMethods.Post, ContentType.Xml)]
    public static LoginResultResponse Login(RequestContext context)
    {
        // TODO: generate a token
        string token = "token";
        
        return new LoginResultResponse
        {
            AuthTicket = $"MM_AUTH={token}",
            LbpEnvVer = "Lantern",
        };
    }

    [ApiEndpoint("goodbye", HttpMethods.Post, ContentType.Xml)]
    public static Response Logout(RequestContext context)
    {
        // TODO: revoke token
        
        return OK;
    }
}

[XmlRoot("loginResult")]
public struct LoginResultResponse
{
    [XmlElement("authTicket")]
    public string AuthTicket { get; set; }

    [XmlElement("lbpEnvVer")]
    public string LbpEnvVer { get; set; }
}