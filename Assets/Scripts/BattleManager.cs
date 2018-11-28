using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{

	public List<BasePlayer> Players;
	public List<BaseEnemy> Enemies;
	
	// Use this for initialization
	void Start ()
	{
		GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("Player");
		foreach (GameObject playerObject in playerObjects)
		{
			Players.Add(playerObject.GetComponent<BasePlayer>());
		}
		
		SpawnEnemy();

		Debug.Log(Enemies);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SpawnEnemy()
	{
		Enemies.Add(Instantiate(GameObject.Find("Skeleton").GetComponent<BaseEnemy>()));
		Enemies.Add(Instantiate(GameObject.Find("Skeleton").GetComponent<BaseEnemy>()));

		//TODO: Handle error in case Enemies are over loaded
	}
	
}
