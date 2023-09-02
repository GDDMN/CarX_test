﻿using UnityEngine;
using System.Collections;

public class CannonProjectile : MonoBehaviour {
	public float m_speed = 0.2f;
	public uint m_damage = 10;

	void Update () {
		var translation = transform.forward * m_speed;
		transform.Translate (translation);
	}

	void OnTriggerEnter(Collider other) {
		var hurtable = other.GetComponent<IHurtable>();

		if (hurtable != null)
			hurtable.TakeDamage(m_damage);
	}
}
