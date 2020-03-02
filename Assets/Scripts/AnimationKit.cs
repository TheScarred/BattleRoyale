using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Kits/AnimationKit")]
public class AnimationKit : ScriptableObject
{
    public AnimationClip[] attack,death;

    public AnimationClip special1, special2;
}
