using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsBarManager : MonoBehaviour
{

	public Slider HpBar;
	public Slider MpBar;
	private BasePlayer _player;
	
	// Use this for initialization
	void Start ()
	{
		_player = GameObject.Find("Player").GetComponent<BasePlayer>();
		HpBar.maxValue = _player.MaxHP;
		MpBar.maxValue = _player.MaxMP;

	}
	
	// Update is called once per frame
	void Update ()
	{
		HpBar.value = _player.HP;
		MpBar.value = _player.MP;
	}
}
