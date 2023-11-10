// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using System.Reflection;
using Bunkum.Protocols.Http;

namespace Lantern;

public class GameServer
{
    private readonly BunkumHttpServer _server;

    public GameServer()
    {
        this._server = new BunkumHttpServer();
        this._server.DiscoverEndpointsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public void Start()
    {
        this._server.Start();
    }
}