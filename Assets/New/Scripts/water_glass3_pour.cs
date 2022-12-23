using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_glass3_pour : MonoBehaviour
{

    public GameObject glass4;
    
    void Start() { }


    void Update() { }

        void Step()
    {
        StepManager.step_count = 5;
        glass4.SetActive(true);
    }
}
