using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialButtonBehaviour : MonoBehaviour
{
    public Swipe swipeControls;
    public Button specialButton;

    [SerializeField]
    private byte currentSpecial = 0;

    private byte CurrentSpecial { get { return currentSpecial; } set { currentSpecial = value; } }

    private void Start()
    {
        
    }

    void Update()
    {
        if (swipeControls.SwipeLeft)
            Debug.Log("Swipe Left");
    }

    public void BeginDrag()
    {
        Debug.Log("Begin Drag");
    }



}
