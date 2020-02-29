using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentRoom : MonoBehaviour
{
    private RoomsCanvases roomsCanvases;

    public void Init(RoomsCanvases canvases)
    {
        roomsCanvases = canvases;
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
