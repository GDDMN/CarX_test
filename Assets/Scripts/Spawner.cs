using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public float m_interval = 3;
	public Transform m_moveTarget;

	[SerializeField] private EnemiesUnitConfig _allEnemies;
	private float m_lastSpawn = -1;


  private void Start()
  {
	//	StartCoroutine(EnemySpawn());
  }

  void Update () {
		//if (Time.time > m_lastSpawn + m_interval) {
		//	var newMonster = GameObject.CreatePrimitive (PrimitiveType.Capsule);
		//	var r = newMonster.AddComponent<Rigidbody> ();
		//	r.useGravity = false;
		//	newMonster.transform.position = transform.position;
		//	var monsterBeh = newMonster.AddComponent<Monster> ();
		//	monsterBeh.Init(m_moveTarget);
		//
		//	m_lastSpawn = Time.time;
		//}
	}

	//private IEnumerator EnemySpawn()
  //{
	//	while(true)
  //  {
	//		yield return null;
  //  }
  //}
}
