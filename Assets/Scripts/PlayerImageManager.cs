using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerImageManager : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
		gameObject.GetComponent<Image>().sprite = ImageLoader.GetSprite("player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
