using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerButton : MonoBehaviour
{
    public TMP_Text text;
    [HideInInspector]public Powerup powerUp;
    public PowerEventChannel powerEvent;


    public void OnPowerUpAsign(Powerup pw)
    {
        powerUp = pw;
        text.text = pw.powerName;
    }

    public void OnClick()
    {
        powerEvent.Raise(powerUp);
    }

}
