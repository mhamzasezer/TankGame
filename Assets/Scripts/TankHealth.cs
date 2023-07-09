using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour
{
    public GameObject effectPrefab1;
    public GameObject effectPrefab2;
    public int tankHP;

    public Text HPLabel;

    void Start()
    {
        HPLabel.text = "HP:" + tankHP;        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "EnemyShell"){
            tankHP -= 1;

            HPLabel.text = "HP:" + tankHP;  
            
            Destroy(other.gameObject);

            if(tankHP > 0){
                GameObject effect1 = Instantiate(effectPrefab1, transform.position, Quaternion.identity);
                Destroy(effect1, 1.0f);
            }else{
                GameObject effect2 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect2, 1.0f);

                Destroy(gameObject);
            }
        }
    }

    public void AddHP(int amount){
        tankHP += amount;

        if(tankHP >10){
            tankHP = 10;
        }
        HPLabel.text = "x" + tankHP;
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}
