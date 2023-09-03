using UnityEngine;


[CreateAssetMenu(fileName = "EnemyConfig", menuName ="Configs/EnemyConfig")]
public class EnemyUnitConfig : ScriptableObject
{
  [SerializeField] private EnemyData _data;

  public EnemyData Data => _data;

  public void Init()
  {
  }
}
