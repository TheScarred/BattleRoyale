using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyStats stats;

    public bool vivo = true;

    #region VariablesAtaque
    [SerializeField]
    Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask playerLayers;
    #endregion
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
    #endregion

    #region Funcion Ataque
    void AttackEnemy()
    {
        int numerorandom = Random.Range(0, 2);
        animator.Play(enemyAnimKit.attack[numerorandom].name);
        Collider[] hitPlayers = Physics.OverlapSphere(attackPoint.position, attackRange, playerLayers);
    }
    #endregion

    public void FinishAnimationDeath()
    {
        vivo = false;//ya se murio xdxd
    }
   
    void Update()
    {
        if(stats.hp<=0&&vivo)
        {
            Muerte();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            AttackEnemy();

        }
    }
    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
