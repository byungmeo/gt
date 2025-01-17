﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class csTimer : MonoBehaviour {
	public Text timer;
	public float time;
	public Text clearstate;

	public static csTimer instance = null;


	void Awake() {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
		DontDestroyOnLoad (gameObject);

		time = 0;
	}

	// Use this for initialization
	void Start () {
		
		timer.text = time.ToString("F1");
	}

	void Update () {
		if (SceneManager.GetActiveScene ().name == "00-Intro") {
			time = 0;
		} else if (SceneManager.GetActiveScene ().name == "98-PrintScore") {
			timer.enabled = false;	
		} else if (SceneManager.GetActiveScene ().name == "01-Tutorial1") {
			timer.enabled = true;
		}
		if (clearstate.text == "") {
			time += Time.deltaTime;
			timer.text = time.ToString ("F1");
		}
	}
}