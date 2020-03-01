using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyStats stats;

    public bool vivo = true;

    #region VARIABLES DE ANIMACION
    [SerializeField]
    AnimationKit enemyAnimKit;
    [SerializeField]
    Animator animator;
    #endregion

    void Start()
    {
        stats = ScriptableObject.CreateInstance<EnemyStats>();

        stats.hp = (float)Constants.BaseEnemyStats.HP;
        stats.atk = (float)Constants.BaseEnemyStats.ATK;
        stats.spd = (float)Constants.BaseEnemyStats.SPD;
    }
    #region Funcion Muerte enemigo
    void Muerte()
    {
        vivo = false;
        int numerorandom = Random.Range(0, 3);
        Debug.Log(numerorandom);
        animator.Play(enemyAnimKit.death[numerorandom].name);
    }
    public void FinishAnimationDeath()
    {
        vivo = false;//ya se murio xdxd
    }
    #endregion
    void Update()
    {
        if(stats.hp<=0&&vivo)
        {
            Muerte();
        }
    }
}
