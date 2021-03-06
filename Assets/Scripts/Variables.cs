﻿namespace Constants
{
    public enum BasePlayerStats
    {
        HP = 100,
        ATK = 10,
        SPD = 5,
        RNG = 2,
        ROF = 1
    }

    public enum BaseEnemyStats
    {
        HP = 30,
        ATK = 5,
        SPD = 1,
    }

    public enum UpgradeCosts
    {
        MELEE = 50,
        SPECIAL1 = 75,
        SPECIAL2 = 100
    }

    public enum AttackType
    {
        AOE,
        PROJECTILE
    }
}
