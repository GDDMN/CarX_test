using UnityEngine;


public abstract class EnemyUnit : MonoBehaviour, IHurtable
{
  public abstract void Init();
  protected abstract void Move();
  public abstract void TakeDamage(uint damage);
  public abstract void Die();

}