using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSpawner : MonoBehaviour
{
    public void Spawner(Rigidbody AoE)
    {
        Rigidbody AoESkill = Instantiate(AoE, transform.position, transform.rotation) as Rigidbody;
    }
}
