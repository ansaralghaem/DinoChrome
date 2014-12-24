﻿using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {
	
	public Score score;
	public DinoController Dino;
	public Transform Point2Destroy;
	public float Speed = 0.5f;

	private Vector3 aPosition;

	void Start () {
		aPosition = transform.position;
	}

	// Update is called once per frame
	void Update () {
		Vector3 nPosition = new Vector3 (aPosition.x - Speed, aPosition.y, aPosition.z);
		if (!score.isGameOver) {
			transform.Translate (Vector3.left * Speed);
		}

		if (transform.position.x < Point2Destroy.position.x) {
			Destroy(transform.gameObject);
		}
	}
}
