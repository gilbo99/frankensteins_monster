using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Scoreboard_quest : MonoBehaviour
{


    public List<string> todo;  
    public TextMeshProUGUI inRange_text;
    public int count = 0;


    public void Start()
    {
        inRange_text.text = todo[count];
    }

    public void Updatetodo()
    {
        inRange_text.text = todo[count];
        count++;
    }
}
