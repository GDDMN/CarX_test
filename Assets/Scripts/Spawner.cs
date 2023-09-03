using System;
using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	[SerializeField] private Transform m_moveTarget;
	[SerializeField] private EnemiesUnitConfig _allEnemies;
	[SerializeField] private float _spawningSpeed = .2f;

	private float _time = 0f;
	private float _spawnTime = 1f;

	private void Update()
  {
		if (ChechTimeForSpawning())
			Spawn();
	}

	private bool ChechTimeForSpawning()
  {
		if (_spawnTime > _time)
		{
			_time += _spawningSpeed * Time.deltaTime;
			return false;
		}

		return true;
	}

	private void Spawn()
  {
		var enemyConf = _allEnemies.GetBy(EnemiesType.DEFAULT);
		enemyConf.Init(transform, m_moveTarget);
		_time = 0f;
	}
}
