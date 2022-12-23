using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Table : MonoBehaviour
{
    
    public GameObject Cns;
    public Button btn;
   
    public static bool Key;
    public static bool Jey;
    public static bool Jey2;
    public static bool Key2;
    public static bool Close;



    // Start is called before the first frame update
    void Start()
    {
        Key = false;
        Jey = false;
        Jey2 = false;
        Key2 = false;
        Close = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TableShowClose()
    {
        if (Close)
        {
            if (!Key)
            {
                Key = true;
                Jey = true;
                
                Cns.GetComponent<Animator>().Play("TableShow");
            }
        }
        else
        {
            if (!Key2)
            {
                Key2 = true;
                Jey2 = true;
                Cns.GetComponent<Animator>().Play("TableClose");
            }
        }
    }

    public void Tables()
    {
        if (Jey)
        {
            btn.GetComponentInChildren<Text>().text = "<<";
            Jey = false;
            Key = false;
            Close = false;
            //btn.GetChild()

        }
    }

    public void TableStop()
    {
        if (Jey2)
        {
            btn.GetComponentInChildren<Text>().text = ">>";
            
            Jey2 = false;
            Key2 = false;
            Close = true;
        }
    }
}
