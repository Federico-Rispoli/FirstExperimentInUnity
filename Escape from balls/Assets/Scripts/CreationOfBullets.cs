using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationOfBullets : MonoBehaviour
{
    [SerializeField] private float timer = 3f;
    public GameObject myPrefab;
    public GameObject wallsx;
    public GameObject walldx;
    private float timing = 0f;
    // Update is called once per frame
    private void Start()
    {
        
    }
    void Update()
    {

        
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (timer<=0)
        {
            var spawn = new Vector3(Random.Range(wallsx.transform.position.x, walldx.transform.position.x), 10, Random.Range(wallsx.transform.position.z, walldx.transform.position.z));
            Instantiate(myPrefab, spawn, Quaternion.identity);  //Quaternion richiama la rotazione dell'oggetto
            timer = 2f;
            DecreaseTimer();
        }
        
       
    }
    private void DecreaseTimer()
    {
        if (timing < 15)
        {
            timer = 2f;
        }
        else if (timing < 30)
        {
            timer = 1f;
        }
        else
        {
            timer = 0.5f;
        }
    }
}
