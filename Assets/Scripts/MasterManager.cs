using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Singletons/MasterManager")]
public class MasterManager : SingletonScriptableObject<MasterManager>
{
    [SerializeField]
    private GameSettings gameSettings;

    [SerializeField]
    private GameManager gameManager;

    public static GameSettings GameSettings { get { return Instance.gameSettings; } }

    public static GameManager GameManager { get { return Instance.gameManager; } }
}
