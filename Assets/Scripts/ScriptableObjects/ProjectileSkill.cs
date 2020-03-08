using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Skills/ProjectileSkill")]
public class ProjectileSkill : Special
{
    public Rigidbody projectile;
    public float speed;

    public override void Fire(GameObject emitter)
    {
        emitter.GetComponent<ProjectileLauncher>().Launch(this.projectile, this.speed);
    }
}
