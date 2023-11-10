// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using System.Xml.Serialization;

namespace Lantern.Types.Game.Login;

[XmlRoot("loginResult")]
public struct LoginResultResponse
{
    [XmlElement("authTicket")]
    public string AuthTicket { get; set; }

    [XmlElement("lbpEnvVer")]
    public string LbpEnvVer { get; set; }
}