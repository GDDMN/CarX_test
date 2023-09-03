using UnityEngine;

public class Monster : EnemyUnit {

  private EnemyData _data;
  private Transform _moveTarget;

  private void Update()
  {
    Move();
  }

  public override void Init(Transform moveTarget, EnemyUnitConfig config)
  {
    _moveTarget = moveTarget;
    
    if(_moveTarget == null)
    {
      Debug.LogError("No target to move unit");
      Destroy(gameObject);
    }

		_data = config.Data;
  }

  public override void Move()
  {
    if(Vector3.Distance(transform.position, _moveTarget.position) < _data.ReachDistance)
      Destroy(gameObject);

    transform.position = Vector3.MoveTowards(transform.position, _moveTarget.position, _data.Speed * Time.deltaTime);
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
