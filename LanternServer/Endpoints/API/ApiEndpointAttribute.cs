// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using Bunkum.Protocols.Http;

namespace Lantern.Endpoints.API;

public class ApiEndpointAttribute : HttpEndpointAttribute
{
    private const string basePath = "/v1/";

    public ApiEndpointAttribute
    (
        string path,
        HttpMethods method = HttpMethods.Get,
        string contentType = Bunkum.Listener.Protocol.ContentType.Plaintext
    ) : base(basePath + path, method, contentType)
    { }
}