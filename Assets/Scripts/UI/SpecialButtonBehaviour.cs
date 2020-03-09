using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialButtonBehaviour : MonoBehaviour
{
    public PlayerController player;
    public Swipe swipeControls;
    public Button specialButton;
    Text buttonText;
    Image cooldown;

    private float[] cooldowns;

    [SerializeField]
    private byte currentSpecial = 0;
    private byte CurrentSpecial { get { return currentSpecial; } set { currentSpecial = value; } }

    private void Start()
    {
        buttonText = specialButton.GetComponentInChildren<Text>();
        cooldown = buttonText.GetComponentInChildren<Image>();
        cooldown.fillAmount = 0;
        cooldowns = new float[player.specials.Length];
    }

    void Update()
    {
        ButtonGesture();

        StartCoroutine(UpdateCooldowns());
    }

    public void BeginDrag()
    {
        Debug.Log("Begin Drag");
    }

    public void UseSpecial()
    {
        player.UseSpecial(currentSpecial);
        cooldowns[currentSpecial] = player.specials[currentSpecial].cooldown;
        specialButton.interactable = false;
    }

    public void ButtonGesture()
    {
        if (swipeControls.SwipeRight)
        {
            if (CurrentSpecial > 0)
                CurrentSpecial--;
            else
                CurrentSpecial = (byte)(player.specials.Length - 1);

            UpdateButton();
        }
        else if (swipeControls.SwipeLeft)
        {
            if (CurrentSpecial < player.specials.Length - 1)
                CurrentSpecial++;
            else
                CurrentSpecial = 0;

            UpdateButton();
        }
    }

    public void UpdateButton()
    {
        if (cooldowns[CurrentSpecial] <= 0)
            specialButton.interactable = true;
        else
            specialButton.interactable = false;

        buttonText.text = player.specials[CurrentSpecial].specialName;
        cooldown.fillAmount = cooldowns[CurrentSpecial];

    }

    public IEnumerator UpdateCooldowns()
    {
        for (byte i = 0; i < cooldowns.Length; i++)
            if (cooldowns[i] > 0)
            {
                cooldowns[i] -= Time.deltaTime;

                if (cooldowns[i] < 0)
                    cooldowns[i] = 0;

                if (i == CurrentSpecial)
                {
                    cooldown.fillAmount = cooldowns[i] / player.specials[i].cooldown;

                    if (cooldowns[i] == 0)
                        specialButton.interactable = true;
                }
            }

        yield return null;
    }

}
