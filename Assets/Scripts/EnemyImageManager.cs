using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class EnemyImageManager : MonoBehaviour
{
	public List<GameObject> spots;
	
	public BattleManager battleManager;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//TODO: mod to use the spot for boss
		int numEnemies = battleManager.Enemies.Count;
		if(numEnemies > 0)
		{
			if (numEnemies == 2)
			{
				for (int i = 0; i < 2; i++)
				{
					Sprite icon;
					if (!battleManager.Enemies[i].IsDead)
					{
						icon = battleManager.Enemies[i].Icon;
					}
					else
					{
						icon = ImageLoader.GetSprite("meatpile");
					}
					spots[i+3].GetComponent<Image>().sprite = icon;
				}
			}
			else
			{
				for (int i = 0; i < numEnemies; i++)
				{
					Sprite icon;
					if (!battleManager.Enemies[i].IsDead)
					{
						icon = battleManager.Enemies[i].Icon;
					}
					else
					{
						icon = ImageLoader.GetSprite("meatpile");
					}
					spots[i].GetComponent<Image>().sprite = icon;
				}
			}
		}
	}
}
