using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro.Examples;
using UnityEngine.UI;

public class Quest_Player : MonoBehaviour
{
    public List<string> lines;

    public bool CanTalk;
    

    public TextMeshPro text;
    public TextMeshProUGUI inRange_text;
    public TextConsoleSimulator TextSim;

    public float timer;

    public int line_Count;


    private void Update()
    {
        if(Input.GetKeyDown("f") && CanTalk)
        {
            UpdateText();
            
        }



        timer -= Time.deltaTime;



        if (CanTalk)
        {
            inRange_text.text = "press F to Talk";
        }
        else
        {
            inRange_text.text = "";

        }


    }
    public void UpdateText()
    {
        if (lines.Count != line_Count && timer <= 0)
        {
            TextSim.TextSwapped();
            TextSim.PlayText();
            text.text = lines[line_Count];
            timer = 1.5f;
            line_Count++;
        }
        
        
    }




    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            CanTalk = true;

            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CanTalk = false;

        }
    }

}
