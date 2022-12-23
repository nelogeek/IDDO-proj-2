using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Pointer_prompt : MonoBehaviour
{
    public GameObject prompt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        prompt.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        prompt.SetActive(false);
    }
}
