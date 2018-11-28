using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : BasePlayer {
	private void Awake()
	{
		this.Name = "Knight";
		this.Icon = ImageLoader.GetSprite("knight");
		this.MaxHP = 100;
		this.MaxMP = 50;
		this.HP = MaxHP;
		this.MP = MaxMP;

		this.ATK = 15;
		this.DFC = 15;
		this.SPD = 15;
		
		this.AttackMoves.Add(Attacks.SLASH);
		this.AttackMoves.Add(Attacks.THRUST);
		
		this.MagicMoves.Add(Magics.FIREBALL);
		
		this.Inventory.Add(Items.MAGICAL_GRASS);
	}

}
