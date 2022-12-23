using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glass2_take : MonoBehaviour
{
    public GameObject glass2;
    public GameObject glass3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Step()
    {
        StepManager.step_count = 4;
    }

    void glass3_on()
    {
        glass3.SetActive(true);
        glass2.SetActive(false);
    }
}
