using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {

	// Use this for initialization
	void Start ()
	{
		this.MaxHP = 100;
		this.MaxMP = 50;
		this.HP = MaxHP;
		this.MP = MaxMP;

		this.ATK = 15;
		this.DFC = 15;
		this.SPD = 15;
		
		this.MagicMoves.SetValue("Fireball", 0);
	}
	
}
