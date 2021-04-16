using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
	public int shinyCounter = 0;
    public int lastEncounter = 0;
    public GameObject textDisplay;

    private void Start()
    {
        shinyCounter = 0;
        textDisplay.GetComponent<Text>().text = "Encounters: " + shinyCounter;
    }

    void Update()
    {
        textDisplay.GetComponent<Text>().text = "Encounters: " + shinyCounter;
        if (Input.GetButtonDown("Up"))
        {
            Increase();
        }
        else if (Input.GetButtonDown("Down"))
        {
            Decrease();
        }
    }

    public void Increase()
    {
            shinyCounter++;
            textDisplay.GetComponent<Text>().text = "Encounters: " + shinyCounter;
    }

    public void Decrease()
    {
            shinyCounter--;
            textDisplay.GetComponent<Text>().text = "Encounters: " + shinyCounter;
    }

    public void SaveEncounters()
    {
        SaveSystem.SaveEncounter(this);
    }

    public void LoadEncounters()
    {
        SaveData data = SaveSystem.LoadData();
        shinyCounter = data.encounter;
    }

    public void ResetCounter()
    {
        shinyCounter = 0;
    }
  
}
