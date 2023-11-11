// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using System.Xml.Serialization;
using Lantern.Types.Database.User;

namespace Lantern.Types.Game.User;

[XmlRoot("npHandle")]
[XmlType("npHandle")]
public class NpHandle
{
    [XmlText]
    public string Username { get; set; } = string.Empty;

    [XmlAttribute("icon")]
    public string Icon { get; set; } = "0";

    public static NpHandle CreateFromUser(DbUser user) => new()
    {
        Username = user.Username,
        Icon = user.Icon,
    };
}