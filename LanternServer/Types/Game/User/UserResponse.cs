// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using System.Xml.Serialization;
using Lantern.Types.Database.User;

namespace Lantern.Types.Game.User;

[XmlRoot("user")]
public class UserResponse
{
    [XmlAttribute("type")]
    public string Type { get; set; } = "user";
    
    [XmlElement("npHandle")]
    public NpHandle Handle { get; set; }
    
    [XmlElement("biography")]
    public string Bio { get; set; } = string.Empty;
    
    [XmlElement("location")]
    public UserLocation? Location { get; set; } = UserLocation.Zero;

    public static UserResponse? CreateFromDbUser(DbUser? user)
    {
        if (user == null)
        {
            return null;
        }

        return new UserResponse
        {
            Handle = new NpHandle
            {
                Username = user.Username,
                Icon = user.Icon,
            },
            Bio = user.Bio,
            Location = user.Location,
        };
    }
}