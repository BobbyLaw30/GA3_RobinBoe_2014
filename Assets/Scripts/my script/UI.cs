using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour 
{ 
    public GameObject UiObject;
    // Start is called before the first frame update
    void Start()
    {
      UiObject.SetActive(false);  
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider Player) 
    {
        if (Player.gameObject.tag == "Player") 
        {
            UiObject.SetActive(true);  
            StartCoroutine("WaitForSec"); 

            
        }
    }  
    IEnumerator WaitForSec() 
    {
        yield return new WaitForSeconds(26); 
        Destroy(UiObject); 
        Destroy(gameObject);
    }
    
        
     

    
}
