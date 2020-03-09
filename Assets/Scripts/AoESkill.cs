using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skills/AoESkill")]
public class AoESkill : Special
{
    public Rigidbody AoE;

    public override void AOEStun(GameObject player)
    {
        player.GetComponent<SkillSpawner>().Spawner(this.AoE);
    }
}
