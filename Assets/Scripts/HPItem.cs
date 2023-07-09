using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPItem : MonoBehaviour
{
    public AudioClip getSound;
    public GameObject effectPrefab;
    private TankHealth th;
    private int reward = 3;

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            th = GameObject.Find("Tank").GetComponent<TankHealth>();

            th.AddHP(reward);

            Destroy(gameObject);

            AudioSource.PlayClipAtPoint(getSound, Camera.main.transform.position);

            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

            Destroy(effect, 0.5f);
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
