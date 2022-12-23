using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spoon_Put : MonoBehaviour
{

    public GameObject heap;

    public GameObject glass_prop_1;
    public GameObject glass_prop_2;
    public GameObject glass_prop_3;
    public GameObject glass_prop_4;

    public GameObject spoon2;
    public GameObject spoon1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Put_On()
    {
        heap.SetActive(true);
    }

    void Put_Off()
    {
        heap.SetActive(false);
    }

    void Step()
    {
        StepManager.step_count = 3;
    }

    void prop_1()
    {
        glass_prop_1.SetActive(true);
    }

    void prop_2()
    {
        glass_prop_1.SetActive(false);
        glass_prop_2.SetActive(true);
    }

    void prop_3()
    {
        glass_prop_2.SetActive(false);
        glass_prop_3.SetActive(true);
    }

    void prop_4()
    {
        glass_prop_3.SetActive(false);
        glass_prop_4.SetActive(true);
    }

    void end()
    {
        spoon2.SetActive(false);
        spoon1.SetActive(true);
    }
}
