// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

using System.Security.Cryptography;
using System.Text;

namespace Lantern.Helpers;

/*
 * Bits and pieces of this file are derived from ProjectLighthouse.
 * https://github.com/LBPUnion/ProjectLighthouse/blob/main/ProjectLighthouse/Helpers/CryptoHelper.cs
 */

public static class CryptoHelper
{
    /// <summary>
    ///     Generates a random authentication token.
    /// </summary>
    /// <returns>SHA256 and BCrypted authentication token.</returns>
    public static string GenerateAuthToken()
    {
        byte[] bytes = (byte[])GenerateRandomBytes(256);

        return BCryptHash(Sha256Hash(bytes));
    }

    /// <summary>
    ///     Generates a specified amount of random bytes in an array.
    /// </summary>
    /// <param name="count">The amount of bytes to generate.</param>
    /// <returns>The bytes generated</returns>
    private static IEnumerable<byte> GenerateRandomBytes(int count) => RandomNumberGenerator.GetBytes(count);

    #region Hash functions

    private static string Sha256Hash(string str) => Sha256Hash(Encoding.UTF8.GetBytes(str));

    private static string Sha256Hash(byte[] bytes) => BitConverter.ToString(SHA256.HashData(bytes)).Replace("-", "").ToLower();

    private static string BCryptHash(string str) => BCrypt.Net.BCrypt.HashPassword(str);

    #endregion
}