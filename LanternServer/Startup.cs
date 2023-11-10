// Lantern - open-source custom server for LittleBigPlanet
// Copyright (C) 2023 sudokoko/Metraberryy

global using static System.Net.HttpStatusCode;
using Bunkum.Core;
using Lantern;

BunkumConsole.AllocateConsole();

GameServer gameServer = new();
gameServer.Start();

await Task.Delay(-1);