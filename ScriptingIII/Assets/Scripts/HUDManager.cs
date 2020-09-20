using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    private int healthCounter;
    private int comboCounter;
    private int health;

    private static HUDManager instance;

    private static HUDManager Instance
    {
        get
        {
            return instance;
        }
        set
        {

        }
    }
    private void Awake()
    {
        instance = this;
    }
    public void AdjustHealth()
    {
        healthCounter += health;

        HUDManager myHUD = Instance;
    }
    public void AddComboCounter(int combo)
    {
        comboCounter += combo;
        Debug.Log("ADDEDCOMBO");
    }

    private float GetFloatCalculation()
    {
        return 1f;
    }
}
