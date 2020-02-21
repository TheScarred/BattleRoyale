using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] characters;
    public PlayerStats stats;

    // Start is called before the first frame update
    void Start()
    {
        stats = ScriptableObject.CreateInstance<PlayerStats>();
        stats.hp = (float)Constants.BaseStats.HP;
        stats.atk = (float)Constants.BaseStats.ATK;
        stats.spd = (float)Constants.BaseStats.SPD;
        stats.rng = (float)Constants.BaseStats.RNG;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
