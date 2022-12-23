using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_btn : MonoBehaviour
{

    public GameObject btn1;
    public GameObject btn2;
    // Start is called before the first frame update

    public void show() {
        btn1.SetActive(true);
        btn2.SetActive(true);
    }
}
