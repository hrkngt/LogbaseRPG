using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public int HP;
    public int MaxHP;
    public int MP;
    public int MaxMP;

    public int ATK;
    public int DFC;
    public int SPD;

    public String[] AttackMoves;
    public String[] MagicMoves;
    public String[] Inventory;

    public void Attack(Character victim)
    {
        victim.GetDamage(this.ATK);
    }

    public void GetDamage(int damage)
    {
        if (this.HP - damage > 0)
        {
            this.HP -= damage;
        }
        else
        {
            this.HP = 0;
        }
    }

}
