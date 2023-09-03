using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "all_enemies", menuName = "Cofigs/all_enemies")]
public class EnemiesUnitConfig : ScriptableObject
{
  [SerializeField] private List<EnemyUnitConfig> _allEnemies;

  public EnemyUnitConfig GetBy(EnemiesType type)
  {
    foreach(var enemy in _allEnemies)
    {
      if (enemy.Data.Type != type)
        continue;

      return enemy;
    }

    return null;
  }
}
