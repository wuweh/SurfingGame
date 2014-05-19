﻿using UnityEngine;
using System.Collections;

public class WaterFx : MonoBehaviour {

	public BoardController board;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( board.isGround && this.particleEmitter.emit == false ) {
			this.particleEmitter.emit = true;
		}
		if ( board.isGround == false && this.particleEmitter.emit ) {
			this.particleEmitter.emit = false;
		}
	}
}
