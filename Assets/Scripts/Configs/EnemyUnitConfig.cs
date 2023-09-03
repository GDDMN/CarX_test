using UnityEngine;


[CreateAssetMenu(fileName = "EnemyConfig", menuName ="Configs/EnemyConfig")]
public class EnemyUnitConfig : ScriptableObject
{
  [SerializeField] private EnemyData _data;
  [SerializeField] private EnemyUnit _unit;

  public EnemyData Data => _data;

  public void Init(Transform moveTarget)
  {
    _unit.Init(moveTarget, _data);
  }
}
