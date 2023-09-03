using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	[SerializeField] private Transform m_moveTarget;
	[SerializeField] private EnemiesUnitConfig _allEnemies;
	[SerializeField] private float _spawningSpeed = .2f;

	private float _time = 0f;
	private float _spawnTime = 1f;

  private void Start()
  {
		StartCoroutine(EnemySpawn());
  }

	private IEnumerator EnemySpawn()
  {
		while(_spawnTime <= _time)
    {
			_time += _spawningSpeed * Time.deltaTime;
			yield return null;
    }

		var enemyConf = _allEnemies.GetBy(EnemiesType.DEFAULT);
		enemyConf.Init(transform, m_moveTarget);
		_time = 0f;

		StartCoroutine(EnemySpawn());
	}
}
