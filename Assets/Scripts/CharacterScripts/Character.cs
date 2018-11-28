using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

public class Character : MonoBehaviour
{
    public String Name;
    public Sprite Icon;
    
    public int HP;
    public int MaxHP;
    public int MP;
    public int MaxMP;

    public int ATK;
    public int DFC;
    public int SPD;

    public bool IsDead;

    private void Update()
    {
        this.IsDead = this.HP <= 0 ? true : false;
    }
}
