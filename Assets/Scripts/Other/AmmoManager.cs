﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class AmmoManager : MonoBehaviour {

	public static int ammo = 0;
	public static bool hasBackpack;
	Text text;


	void Awake ()
	{
		text = GetComponent <Text> ();
		if (SceneManager.GetActiveScene().name == "niveau1")
			hasBackpack = false;
		else
			hasBackpack = true;
	}


	void Update ()
	{
		text.text = ""+ammo;
	}

	public static void addAmmo(int number){
		ammo += number;
	}

	public static void shot(){
		ammo--;
	}
}
