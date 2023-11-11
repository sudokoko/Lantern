// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using Bunkum.RealmDatabase;
using Lantern.Types.Game;
using Lantern.Types.Database.User;
using Realms;

namespace Lantern.Database;

public class LanternDatabaseProvider : RealmDatabaseProvider<LanternDatabaseContext>
{
    protected override ulong SchemaVersion => 1;
    protected override string Filename => "lantern.realm";

    protected override List<Type> SchemaTypes { get; } = new()
    {
        typeof(DbUser),
        typeof(UserLocation),
    };

    public override void Warmup()
    { }

    protected override void Migrate(Migration migration, ulong oldVersion)
    { }
}