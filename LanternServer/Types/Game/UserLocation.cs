// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using System.Xml.Serialization;
using Realms;

namespace Lantern.Types.Game;

[XmlType("location")]
public partial class UserLocation : IEmbeddedObject
{
    public static UserLocation? Zero => new()
    {
        X = 0,
        Y = 0,
    };

    [XmlElement("y")]
    public int X { get; set; }

    [XmlElement("x")]
    public int Y { get; set; }
}