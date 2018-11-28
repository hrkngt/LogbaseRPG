using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : BaseEnemy {

	// Use this for initialization
	void Awake ()
	{
		this.Name = "Skeleton";
		this.Icon = ImageLoader.GetSprite("skeleton");
		this.MaxHP = 30;
		this.MaxMP = 10;
		this.HP = MaxHP;
		this.MP = MaxMP;

		this.ATK = 10;
		this.DFC = 5;
		this.SPD = 15;
	}
	
	//TODO: give a variety of attack moves
	public void Attack()
	{
		
	}

	public void GetDamage(int damage)
	{
		this.HP -= damage;
	}
	
}
