using UnityEngine;


[CreateAssetMenu(fileName = "EnemyConfig", menuName ="Configs/EnemyConfig")]
public class EnemyUnitConfig : ScriptableObject
{
  [SerializeField] private EnemyData _data;
  [SerializeField] private EnemyUnit _unit;

  public EnemyData Data => _data;
  public EnemyUnit Unit => _unit;

}
