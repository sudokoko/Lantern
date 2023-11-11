// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using Bunkum.Core;
using Bunkum.Core.Endpoints;
using Bunkum.Listener.Protocol;
using Lantern.Attributes;
using Lantern.Database;
using Lantern.Types.Database.User;
using Lantern.Types.Game.User;

namespace Lantern.Endpoints.Game;

public class UserEndpoints : EndpointGroup
{
    [GameEndpoint("user/{username}", default, ContentType.Xml)]
    public static UserResponse? GetUser(RequestContext context, LanternDatabaseContext databaseContext, string username)
    {
        DbUser? user = databaseContext.FindUserWithName(username);
        if (user == null)
        {
            return null;
        }
        UserResponse? response = UserResponse.CreateFromDbUser(user);
        return response;
    }
}