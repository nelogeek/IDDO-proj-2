using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polimer_spoon3 : MonoBehaviour
{
    public GameObject polimer;
    public GameObject water2_glass4;
    void Start() { }
    void Update() { }
    void on()
    {
        polimer.SetActive(true);
        water2_glass4.SetActive(false);

        StepManager.step_count = 7;
    }
}
