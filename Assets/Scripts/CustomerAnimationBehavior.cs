using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerAnimationBehavior : MonoBehaviour
{

    Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerCollider2D(Collider2D collision){
        if(collision.transform.position.x < this.transform.position.x){
            Debug.Log("Collision");
            anim.Stop();
        }
        else{
            anim.Play();
        }
    }
}
