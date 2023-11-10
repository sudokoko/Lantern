// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using System.Reflection;
using Bunkum.Protocols.Http;

namespace Lantern;

public class GameServer
{
    private readonly BunkumHttpServer server;

    public GameServer()
    {
        this.server = new BunkumHttpServer();
        this.server.DiscoverEndpointsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public void Start()
    {
        this.server.Start();
    }
}