using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSkillManager : MonoBehaviour
{
    public ProjectileSkill swordBeam;
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
}
