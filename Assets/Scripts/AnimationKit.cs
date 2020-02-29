using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Kits/AnimationKit")]
public class AnimationKit : ScriptableObject
{
    public AnimationClip[] attackAnim;

    public AnimationClip special1Anim, special2Anim;
}
