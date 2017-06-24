using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour {
	public Button btnLogin;
	public GameObject soundBackground;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (soundBackground);
	}

	void Awake() {
		btnLogin.onClick.AddListener (onPressLogin);
	}
		
	
	// Update is called once per frame
	void Update () {
		
	}

	void onPressLogin() {
		SceneManager.LoadScene ("_SceneMain");
	}
}
