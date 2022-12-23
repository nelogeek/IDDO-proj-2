using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weights : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject o_text;
    public GameObject spoon4;
    public GameObject spoon5;
    public GameObject polimer_3;

    void w_1()
    {
        o_text.GetComponent<TextMesh>().text = "33";
    }

    void w_2()
    {
        o_text.GetComponent<TextMesh>().text = "76";
    }

    void w_3()
    {
        o_text.GetComponent<TextMesh>().text = "120";
        StepManager.step_count = 11;
        spoon4.SetActive(false);
        spoon5.SetActive(true);
        polimer_3.SetActive(true);
    }
}
