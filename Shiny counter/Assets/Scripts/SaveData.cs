using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public int encounter;
    public int lastEncounter;

    public SaveData(Counter counter)
    {
        encounter = counter.shinyCounter;
    }

}
