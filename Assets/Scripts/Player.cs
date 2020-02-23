using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Joystick joystick;
    public PlayerStats stats;
    public Rigidbody rigi;
    public GameObject[] characters;


    //animator y layer para los objetivos
    public Animator animator;
    public LayerMask enemyLayers;
    public float attackRange = 0.5f;

    [SerializeField]
    Transform attackPoint;

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        rigi = GetComponent<Rigidbody>();
        stats = ScriptableObject.CreateInstance<PlayerStats>();

        stats.hp = (float)Constants.BaseStats.HP;
        stats.atk = (float)Constants.BaseStats.ATK;
        stats.spd = (float)Constants.BaseStats.SPD;
        stats.rng = (float)Constants.BaseStats.RNG;
    }



    void Update()
    {
        Attack();
        if (joystick.Direction != Vector2.zero)
            Move();
    }



    void Attack()
    {
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider enemy in hitEnemies)
        {
            Debug.Log("Golpeado por espada" + enemy.name);
        }


    }
    void Move()
    {
        transform.eulerAngles = new Vector3(0, Mathf.Atan2(joystick.Vertical, -joystick.Horizontal) * 180 / Mathf.PI, 0);
        rigi.MovePosition(transform.position + (new Vector3(joystick.Vertical, 0, -joystick.Horizontal) * Time.fixedDeltaTime * stats.spd));
    }
    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }


}