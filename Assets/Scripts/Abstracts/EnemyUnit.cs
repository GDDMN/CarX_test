using UnityEngine;


public abstract class EnemyUnit : MonoBehaviour, IHurtable, IMove
{
  public abstract void Init(Transform moveTarget, EnemyUnitConfig config);
  public abstract void Move();
  public abstract void TakeDamage(uint damage);
  public abstract void Die();

}