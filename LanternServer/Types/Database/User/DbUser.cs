// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using Lantern.Types.Game;
using MongoDB.Bson;
using Realms;

namespace Lantern.Types.Database.User;

public partial class DbUser : IRealmObject
{
    [PrimaryKey]
    [MapTo("_id")]
    public ObjectId UserId { get; set; } = ObjectId.GenerateNewId();

    [Indexed]
    public string Username { get; set; } = "";
    
    public string Icon { get; set; } = "0";
    public string Bio { get; set; } = "";
    public UserLocation? Location { get; set; } = UserLocation.Zero;
}