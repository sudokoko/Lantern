// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using Bunkum.Protocols.Http;

namespace Lantern.Attributes;

public class GameEndpointAttribute : HttpEndpointAttribute
{
    private const string basePath = "/game/";

    public GameEndpointAttribute
    (
        string path,
        HttpMethods method = HttpMethods.Get,
        string contentType = Bunkum.Listener.Protocol.ContentType.Plaintext
    ) : base(basePath + path, method, contentType)
    { }
}