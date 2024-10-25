using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CustomerBehavior : MonoBehaviour
{
    [SerializeField] private GameObject orderButton;
    [SerializeField] private GameObject closerOrderButton;
    [SerializeField] private Transform customerEndTransform;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        customerEndTransform = GameObject.Find("CustomerEndLoc").transform;
        anim = gameObject.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // Make a function? that moves the character to ending pos if there's a collision stop early and make button appear when in pos??? 
        if(gameObject.transform.position.x <= customerEndTransform.position.x){
            anim.enabled = false;
            if(!orderButton.activeSelf){
                orderButton.SetActive(true);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log(collision.transform.position.x);
        if(collision.transform.position.x < this.transform.position.x){
            Debug.Log("Collision");
            // anim.Stop();
        }
        else{
            // anim.Play(); 
        }
    }

    void OnTriggerEnter2D(Collider2D collider){
        Debug.Log("Entered");
        Debug.Log(collider.transform.position.x);
        if(collider.transform.position.x < this.transform.position.x){
            anim.enabled = false;
        }
        else{
            anim.enabled=true;
        }
    }

    void OnTriggerExit2D(Collider2D collider){
        Debug.Log("Exited");
        if(collider.transform.position.x < this.transform.position.x){
            anim.enabled = true;
        }
    }
}
