// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using Bunkum.RealmDatabase;
using Lantern.Types.Database.User;
using Realms;

namespace Lantern.Database;

public class LanternDatabaseContext : RealmDatabaseContext
{
    public DbUser CreateUser(string username)
    {
        DbUser newUser = new()
        {
            Username = username,
        };

        return this.AddAndWrite(newUser);
    }

    public DbUser? FindUserWithName(string username)
    {
        DbUser? user = this._realm.All<DbUser>().First(u => u.Username == username);
        return user;
    }

    private T? AddAndWrite<T>(T obj) where T : IRealmObject
    {
        T? ret = default;
        this._realm.Write(() =>
        {
            ret = this._realm.Add(obj);
        });
        return ret;
    }
}