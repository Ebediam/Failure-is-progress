using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSelector : MonoBehaviour
{
    public VoidEventChannel deathEvent;
    public List<Powerup> powerups;
    public List<PowerButton> buttons;
    public Powerup flyPowerup;
    public PowerEventChannel powerSelectedEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        deathEvent.VoidEvent += OnDeath;

        powerSelectedEvent.PowerEvent += OnPowerSelected;
        
    }


    void OnDeath()
    {
        if(powerups.Count == 0)
        {
            powerups.Add(flyPowerup);
            
        }

        List<Powerup> _pws = new List<Powerup>(powerups);

        foreach (PowerButton button in buttons)
        {
            
            if(_pws.Count == 1)
            {

                button.OnPowerUpAsign(_pws[0]);
            }
            else
            {
                int i = Random.Range(0, _pws.Count);
                button.OnPowerUpAsign(_pws[i]);
                _pws.RemoveAt(i);
            }  

        }

        gameObject.SetActive(true);
        
    }

    void OnPowerSelected(Powerup powerup)
    {
        gameObject.SetActive(false);

        powerup.powerupEvent.Raise();

        if (powerups.Contains(powerup))
        {
            powerups.Remove(powerup);
        }
        

    }

    



}
