using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSkillManager : MonoBehaviour
{
    public ProjectileSkill swordBeam;
    public AoESkill Stun;
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            this.swordBeam.Fire(this.gameObject);
        }
    }
    public void FireSwordBeam()
    {
        this.swordBeam.Fire(this.gameObject);
    }
    public void SpawnAoE()
    {
        this.Stun.AOEStun(this.gameObject);
    }
}
