// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using System.Reflection;
using Bunkum.Protocols.Http;
using Lantern.Database;

namespace Lantern;

public class GameServer
{
    private readonly BunkumHttpServer server;
    private readonly LanternDatabaseProvider databaseProvider;

    public GameServer()
    {
        LanternDatabaseProvider provider = new();
        
        this.databaseProvider = provider;
        this.server = new BunkumHttpServer();
        this.server.DiscoverEndpointsFromAssembly(Assembly.GetExecutingAssembly());
        this.server.UseDatabaseProvider(provider);
    }

    public void Start()
    {
        this.server.Start();
    }
}