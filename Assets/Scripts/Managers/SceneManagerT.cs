using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerT : MonoBehaviour
{
    public static SceneManagerT instance;
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }
    public void GameScene()
    {
        SceneManager.LoadScene(2);
    }
    public void ShopScene()
    {
        SceneManager.LoadScene(3);
    }
    public void CustomizeScene()
    {
        SceneManager.LoadScene(5);
    }
    public void CharacterSelectScene()
    {
        SceneManager.LoadScene(6);
    }
    public void SettingsScene()
    {
        SceneManager.LoadScene(4);
    }
    public void MainMenuScene()
    {
        SceneManager.LoadScene(1);
    }
}
