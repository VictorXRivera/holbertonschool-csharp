﻿using System;
///<summary>Player class</summary>///
public class Player
{
    ///<summary>Parameter</summary>///
    private string name;
    ///<summary>Parameter</summary>///
    private float maxHp;
    ///<summary>Parameter</summary>///
    private float hp;
    
    ///<summary>Constructor</summary>///
    /// <param name="name">Defaulted to "Player"</param>///
    /// <param name="maxHp">Defaulted to 100.0f</param>///
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine ("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        hp = this.maxHp = maxHp;
    }

    ///<summary>Delegate for health</summary>///
    public delegate float CalculateHealth(float damage);

    /// <summary>
    /// Validates "newHp" and updates "hp"
    /// </summary>
    /// <param name="newHp">amount to modify "hp" by pre-validation</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            hp = 0f;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
    }

    ///<summary>Damage method</summary>///
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }
    ///<summary>Health method</summary>///
    public void HealDamage(float heal)
    {
        if (heal < 0)
        heal = 0;
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    ///<summary>Printhealth method</summary>///
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}