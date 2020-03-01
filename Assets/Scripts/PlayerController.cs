using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private byte specialCount = 2;

    public Joystick joystick;
    public Button specialButton;
    public PlayerStats stats;
    public Special[] specials;
    public Rigidbody rigi;
    public GameObject[] characters;
    public bool movimiento = false;



    //animator y layer para los objetivos
    public AnimationKit animKit;
    public Animator animator;
    public LayerMask enemyLayers;
    public LayerMask playerLayers;


    public float attackRange = 0.5f;

    [SerializeField]
    Transform attackPoint;

    //Ataque
    private bool attack = true;

    //public static bool Attack { get { return attack; } set { attack = value; } }

    public void CanAttack() => attack = true;
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        rigi = GetComponent<Rigidbody>();
        specials = new Special[specialCount];

        stats = ScriptableObject.CreateInstance<PlayerStats>();
        
        for (byte i = 0; i < specialCount; i++)
        {
            specials[i] = ScriptableObject.CreateInstance<Special>();
            specials[i].id = i;
            specials[i].specialName = " Special " + (i + 1).ToString();
        }

        stats.hp = (float)Constants.BasePlayerStats.HP;
        stats.atk = (float)Constants.BasePlayerStats.ATK;
        stats.spd = (float)Constants.BasePlayerStats.SPD;
        stats.rng = (float)Constants.BasePlayerStats.RNG;

    }


    void Update()
    {

        if (Input.GetMouseButtonDown(1) && attack)
            Attack();

        if (joystick.Direction != Vector2.zero)
            Move();

        else if (joystick.Direction == Vector2.zero)
            movimiento = false;
    }



    void Attack()
    {
        
        attack = false;
        //animacion ataque
        int numerorandom = Random.Range(0, 3);
        animator.Play(animKit.attack[numerorandom].name);

        //agarra a los players golpeados y los lista en un arreglo
        Collider[] hitPlayers = Physics.OverlapSphere(attackPoint.position, attackRange, playerLayers);

        //agarra a los enemigos golpeados y los lista en un arreglo
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
        if (hitEnemies.Length > 0)
        {
            foreach (Collider enemy in hitEnemies)
            {
                //funcion de hacer daño al enemigo
                MakeDamageEnemy(enemy);
                Debug.Log(enemy.GetComponent<Enemy>().stats.hp);
            }

        }
        #region HitPLAYER
        if (hitPlayers.Length > 0)
        {
            foreach (Collider player in hitPlayers)
            {
                //funcion de hacer daño al player
            }
        }
        #endregion
    }

    #region FUNCION DAÑO ENEMY
    public void MakeDamageEnemy(Collider enemy)
    {
        enemy.GetComponent<Enemy>().stats.hp -= 30;

    }
    #endregion
    #region FUNCION DAÑO PLAYER

    public void MakeDamagePlayer()
    {

    }

    #endregion

    void Move()
    {
        movimiento = true;
        transform.eulerAngles = new Vector3(0, Mathf.Atan2(joystick.Vertical, -joystick.Horizontal) * 180 / Mathf.PI, 0);
        rigi.MovePosition(transform.position + (new Vector3(joystick.Vertical, 0, -joystick.Horizontal) * Time.fixedDeltaTime * stats.spd));
    }

    public void UseSpecial(int i) => specials[i].Use();
    public void UpgradeSpecial(int i) => specials[i].Upgrade();

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }


}