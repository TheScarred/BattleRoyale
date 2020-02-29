﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Joystick joystick;
    public PlayerStats stats;
    public Special special1, special2;
    public Rigidbody rigi;
    public GameObject[] characters;

    //animator y layer para los objetivos
    public Animator animator;
    public LayerMask enemyLayers;
    public LayerMask playerLayers;


    public float attackRange = 0.5f;

    [SerializeField]
    Transform attackPoint;
    //Animaciones random ataque
    public AnimationClip[] attackAnimation;

    //Ataque
    public bool attack = false;

    

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        rigi = GetComponent<Rigidbody>();
        stats = ScriptableObject.CreateInstance<PlayerStats>();

        stats.hp = (float)Constants.BasePlayerStats.HP;
        stats.atk = (float)Constants.BasePlayerStats.ATK;
        stats.spd = (float)Constants.BasePlayerStats.SPD;
        stats.rng = (float)Constants.BasePlayerStats.RNG;
    }
    public void CanAttack()
    {
        Debug.Log("hecho");
        attack = true;
    }


    void Update()
    {

        if(Input.GetMouseButtonDown(1)&&attack!=false)
        {
            Attack();

        if (joystick.Direction != Vector2.zero)
            Move();
    }

    void Attack()
    {
        attack = false;
        //animacion ataque
        int numerorandom = Random.Range(0, 3);
        Debug.Log(numerorandom);
        //animator.SetTrigger("AttackTrigger");
        animator.Play(attackAnimation[numerorandom].name);

        //agarra a los players golpeados y los lista en un arreglo
        Collider[] hitPlayers = Physics.OverlapSphere(attackPoint.position, attackRange, playerLayers);

        //agarra a los enemigos golpeados y los lista en un arreglo
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
        if(hitEnemies.Length>0)
        {
            foreach (Collider enemy in hitEnemies)
            {
                //funcion de hacer daño al enemigo

            }

        }

      
        if(hitPlayers.Length>0)
        {
            foreach (Collider player in hitPlayers)
            {
                //funcion de hacer daño al player
            }

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
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }


}