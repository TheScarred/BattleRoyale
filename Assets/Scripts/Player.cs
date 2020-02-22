using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public GameObject prefab;
    //public PlayerController control;
    public PlayerStats stats;
    public GameObject[] characters;

    void Start()
    {
        stats = ScriptableObject.CreateInstance<PlayerStats>();
        stats.hp = (float)Constants.BaseStats.HP;
        stats.atk = (float)Constants.BaseStats.ATK;
        stats.spd = (float)Constants.BaseStats.SPD;
        stats.rng = (float)Constants.BaseStats.RNG;
    }

    private void Awake()
    {
        //control = new PlayerController();
        //control.Player.Fire.started += ctx => Tap();
    }

    //private void OnEnable() => control.Player.Enable();
    //private void OnDisable() => control.Player.Disable();

    void Update()
    {
        /*if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Debug.Log("Touch! X: " + touch.position.x);
        }*/

    }

    public void Tap()
    {
        Debug.Log("Tap!");
        Instantiate(prefab, transform);
    }

    public void Look()
    {
        Debug.Log("Look!");
    }
}
