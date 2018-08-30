﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
	[SerializeField] Text textComponent;
    [SerializeField] State introState;

    State currentState;

	// Use this for initialization
	void Start () {
        currentState = introState;
        textComponent.text = currentState.getStory();
	}

	// Update is called once per frame
	void Update () {
	}
}
