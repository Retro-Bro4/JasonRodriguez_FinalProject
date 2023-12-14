using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject interactionPrompt, dialogue, bubble;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        interactionPrompt.SetActive(true);
    }
    void OnTriggerStay(Collider col){
        if (Input.GetKeyDown("e")){
            dialogue.SetActive(true);
            bubble.SetActive(true);
            interactionPrompt.SetActive(false);
        }
    }
       void OnTriggerExit(Collider col){
        dialogue.SetActive(false);
        bubble.SetActive(false);
       
    
        interactionPrompt.SetActive(false);
    }
}
