using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyStats stats;

    void Start()
    {
        stats = ScriptableObject.CreateInstance<EnemyStats>();

        stats.hp = (float)Constants.BaseEnemyStats.HP;
        stats.atk = (float)Constants.BaseEnemyStats.ATK;
        stats.spd = (float)Constants.BaseEnemyStats.SPD;
    }

    void Update()
    {
        
    }
}
