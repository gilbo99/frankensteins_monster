using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using TMPro.Examples;
using UnityEngine;

public class Random_Words : MonoBehaviour
{

    public List<string> random_sayings;

    public int whatword;

    public TextConsoleSimulator TextSim;

    public float timer;

    public TextMeshPro inRange_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inRange_text.text = random_sayings[whatword];




        if(timer <= 0)
        {
            whatword = Random.Range(0 , random_sayings.Count);
            TextSim.TextSwapped();
            TextSim.PlayText();
            timer = 10f;
        }
        timer -= Time.deltaTime;
    }
}
