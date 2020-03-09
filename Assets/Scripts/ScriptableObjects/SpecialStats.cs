using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special : ScriptableObject
{
    public int id;
    public float cooldown;
    public string specialName;
    public Constants.AttackType type;

    public void Use()
    {
        Debug.Log("Used: " + specialName);
    }

    public void Upgrade()
    {
        Debug.Log("Upgraded: " + specialName);
    }
}
