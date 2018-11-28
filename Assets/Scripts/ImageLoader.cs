using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class ImageLoader : MonoBehaviour {

	public static Sprite GetSprite(String imageName)
	{
		//TODO: Error control for the case which image could not be found.
		return Resources.Load<Sprite>(imageName);
	}
	
	public static GameObject GetSpriteOfImage(String imageName)
	{
		Sprite sprite = Resources.Load<Sprite>(imageName);
		GameObject gameObject = new GameObject();
		Image image = gameObject.AddComponent<Image>();
		image.sprite = sprite;

		float width = sprite.rect.width;
		float height = sprite.rect.height;
		gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(width, height);
		return gameObject;
	}
}
