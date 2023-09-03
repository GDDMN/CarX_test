using System;
using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	[SerializeField] private Transform _moveTarget;
	[SerializeField] private EnemiesUnitConfig _allEnemies;
	[SerializeField] private float _spawningSpeed = .2f;

	private Transform startPos;
	private float _time = 0f;
	private float _spawnTime = 1f;

  private void Start()
  {
		startPos = transform;
  }

  private void Update()
  {
		if (CheckTimeForSpawning())
			Spawn();
	}

	private bool CheckTimeForSpawning()
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
		enemyConf.InitUnit(startPos, _moveTarget);
		_time = 0f;
	}
}
