using UnityEngine;


[CreateAssetMenu(fileName = "EnemyConfig", menuName ="Configs/Enemies/EnemyConfig")]
public class EnemyUnitConfig : ScriptableObject
{
  [SerializeField] private EnemyData _data;
  [SerializeField] private EnemyUnit _unit;

  public EnemyData Data => _data;

  public void InitUnit(Transform startPosition, Transform moveTarget)
  {
    var unit = Instantiate(_unit, startPosition);
    unit.Init(moveTarget, _data);
  }
}
