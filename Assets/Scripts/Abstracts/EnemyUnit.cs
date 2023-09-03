using UnityEngine;


public abstract class EnemyUnit : MonoBehaviour, IHurtable, IMove
{
  public abstract void Init(Transform moveTarget, EnemyData data);
  public abstract void Move();
  public abstract void TakeDamage(uint damage);
  public abstract void Die();

}