using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : Character
{
    public enum Attacks
    {
        SLASH,
        THRUST,
        PUNCH,
        KICK,
        ARROW,
        BOMB,
        HIT
    }

    public enum Magics
    {
        FIREBALL,
        WATERFALL,
        THUNDER_WHATEVER
    }

    public enum Items
    {
        HEALING_POTION,
        WATER_BOTTLE,
        MAGICAL_GRASS,
        AND_SO_ON
    }

    public enum StatusAilment
    {
        POISONED,
        BURNED,
        PARALYZED,
        SILENCED
    }
    
    public List<Attacks> AttackMoves;
    public List<Magics> MagicMoves;
    public List<Items> Inventory;
    public Dictionary<StatusAilment, int> ailment;

    public void Attack(Attacks attackMove)
    {
        
    }

    public void GetDamage(int damage)
    {
        this.HP = damage;
    }

    public void MagicAttack(Magics magic)
    {
        
    }
    

}
