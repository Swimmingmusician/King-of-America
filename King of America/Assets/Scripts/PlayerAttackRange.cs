﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackRange : MonoBehaviour {
	public float damage = 5f;
	float CD;
	public float delayTime = 0.55f;

	void Update()
	{
		CD -= Time.deltaTime;

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.transform.tag == "Enemy") {
			if (col.transform.GetComponent<Slime> () && CD <= 0f) {
				CD = delayTime;
				float hp = col.transform.GetComponent<Slime> ().health;
				col.transform.GetComponent<Slime>().health = Health.DamageHealth (hp, damage);
				col.transform.GetComponent<Slime> ().hurtAnimation ();
			}
		}
	}
}
