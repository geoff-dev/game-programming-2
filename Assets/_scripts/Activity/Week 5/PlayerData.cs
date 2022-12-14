using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public String Name;
    public int Health;
    public Weapon Equipment;

    public PlayerData(string name, int health, Weapon equipment)
    {
        this.Name = name;
        this.Health = health;
        this.Equipment = equipment;
    }

    public PlayerData()
    {
        Name = "June";
        Health = 100;
        Equipment = Weapon.Empty;
    }
}

[JsonConverter(typeof(StringEnumConverter))]
public enum Weapon
{
    Empty,
    Pistol
}
