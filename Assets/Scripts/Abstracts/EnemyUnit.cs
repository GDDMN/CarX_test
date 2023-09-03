using UnityEngine;


public abstract class EnemyUnit : MonoBehaviour
{
  public abstract void Init(Transform moveTarget);
  public abstract void Move();
  public abstract void TakeDamage(uint damage);
  public abstract void Die();

}