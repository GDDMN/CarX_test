using UnityEngine;
using System.Collections;

public class Monster : EnemyUnit {

	[SerializeField] private EnemyUnitConfig _config;

	private EnemyData _data;
  private Transform _moveTarget;

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
    if (_moveTarget == null)
      return;

    if(Vector3.Distance(transform.position, _moveTarget.position) < _data.ReachDistance)
    {
      Destroy(gameObject);
      return;
    }

    var translation = _moveTarget.position - transform.position;
    if (translation.magnitude > _data.Speed)
      translation = translation.normalized * _data.Speed;

    transform.Translate(translation);
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
