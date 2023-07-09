using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectOBJ : MonoBehaviour
{
    public GameObject effectPrefab;

    public GameObject effectPrefab2;
    public int objectHP;

    void OnTriggerEnter(Collider other){
//        if(other.gameObject.tag == "Shell"){

            objectHP -= 1;

            if(objectHP > 0){
                Destroy(other.gameObject);
                GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
                Destroy(effect,2.0f);   
            }else{
                Destroy(other.gameObject);
                GameObject effect = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect,2.0f);
                Destroy(this.gameObject);
            }

        }
//   }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
