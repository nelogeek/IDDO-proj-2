using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glass8_end : MonoBehaviour
{

    public GameObject polimer1;
    public GameObject polimer2;

    public GameObject r;
    public GameObject r1;
    public GameObject r2;
    public GameObject r3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void end()
    {
        polimer1.SetActive(false);
        polimer2.SetActive(true);
        r.SetActive(false);
        r1.SetActive(false);
        r2.SetActive(false);
        r3.SetActive(false);
        StepManager.step_count = 14;
    }

}
