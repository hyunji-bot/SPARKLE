using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerEvent : MonoBehaviour
{
    public Canvas hamburgerCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter() {
        hamburgerCanvas.gameObject.SetActive(true);
        Debug.Log("ÇÜ¹ö°Å");
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.gameObject.SetActive(false);
            hamburgerCanvas.gameObject.SetActive(false);
            Debug.Log("ÇÜ¹ö°Å ºüÀÌ");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        hamburgerCanvas.gameObject.SetActive(false); 
    }
}
