using UnityEngine;
using System.Collections;

public class Monster : EnemyUnit {

	public EnemyUnitConfig _config;
	private EnemyData _data;

  public Transform MoveTarget { set; private get; }

	private void Start() {
		Init();
	}

  private void Update()
  {
    Move();
  }

  public override void Init()
  {
		_data = _config.Data;
  }

  protected override void Move()
  {
    if (MoveTarget == null)
      return;

    if(Vector3.Distance(transform.position, MoveTarget.position) < _data.ReachDistance)
      Destroy(gameObject);

    transform.position = Vector3.MoveTowards(transform.position, MoveTarget.position, _data.Speed * Time.deltaTime);
  }

  public override void TakeDamage(uint damage)
  {
		_data.HP -= damage;

		if (_data.HP <= 0)
			Die();
  }

  public override void Die()
  {
    Destroy(gameObject);
  }
}
