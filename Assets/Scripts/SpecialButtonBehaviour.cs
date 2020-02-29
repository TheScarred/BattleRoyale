using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialButtonBehaviour : MonoBehaviour
{
    [SerializeField]
    private byte specialId = 0;

    private byte SpecialID { get { return specialId; } set { specialId = value; } }
}
