using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeButton : MonoBehaviour
{
    public Swipe swipeControls;
    public GameObject Special1;
    public GameObject Special2;
    // Update is called once per frame
    void Update()
    {
        if (Special1.activeSelf==true && Special2.activeSelf == false) 
        {  
        if (swipeControls.SwipeLeft)
        {
            Special1.SetActive(false);
            Special2.SetActive(true);
        }
        if (swipeControls.SwipeRight)
        {
            Special1.SetActive(false);
            Special2.SetActive(true);
        }
        if (swipeControls.SwipeUp)
        {
            Special1.SetActive(false);
            Special2.SetActive(true);
        }
        if (swipeControls.SwipeDown)
        {
            Special1.SetActive(false);
            Special2.SetActive(true);
        }
        if (swipeControls.Tap)
        {
            Debug.Log("TAP!");
        }
        }
        else if (Special1.activeSelf==false && Special2.activeSelf==true)
        {
            if (swipeControls.SwipeLeft)
            {
                Special1.SetActive(true);
                Special2.SetActive(false);
            }
            if (swipeControls.SwipeRight)
            {
                Special1.SetActive(true);
                Special2.SetActive(false);
            }
            if (swipeControls.SwipeUp)
            {
                Special1.SetActive(true);
                Special2.SetActive(false);
            }
            if (swipeControls.SwipeDown)
            {
                Special1.SetActive(true);
                Special2.SetActive(false);
            }
            if (swipeControls.Tap)
            {
                Debug.Log("TAP!");
            }
        }
    }
}
