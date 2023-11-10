﻿// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using Bunkum.Core;
using Bunkum.Core.Endpoints;
using Bunkum.Core.Responses;
using Bunkum.Listener.Protocol;
using Bunkum.Protocols.Http;
using Lantern.Attributes;
using Lantern.Types.Game.Login;

namespace Lantern.Endpoints.Game;

public class LoginEndpoints : EndpointGroup
{
    private const string licenseText = """
                                       This program is free software: you can redistribute it and/or modify
                                       it under the terms of the GNU Affero General Public License as
                                       published by the Free Software Foundation, either version 3 of the
                                       License, or (at your option) any later version.

                                       This program is distributed in the hope that it will be useful,
                                       but WITHOUT ANY WARRANTY; without even the implied warranty of
                                       MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
                                       GNU Affero General Public License for more details.

                                       You should have received a copy of the GNU Affero General Public License
                                       along with this program.  If not, see <https://www.gnu.org/licenses/>.
                                       """;

    [GameEndpoint("eula")]
    public static string Eula(RequestContext context) => licenseText;

    [GameEndpoint("announce")]
    public static string Announcements(RequestContext context) => "announce";

    [GameEndpoint("login", HttpMethods.Post, ContentType.Xml)]
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

    [GameEndpoint("goodbye", HttpMethods.Post, ContentType.Xml)]
    public static Response Logout(RequestContext context) =>
        // TODO: revoke token
        OK;
}