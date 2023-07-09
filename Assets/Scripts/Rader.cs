using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rader : MonoBehaviour
{
    public Transform target;

    void OnTriggerStay(Collider other){

        if(other.gameObject.tag == "Player"){
            transform.root.LookAt(target);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
