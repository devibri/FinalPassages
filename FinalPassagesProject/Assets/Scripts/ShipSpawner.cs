using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawner : MonoBehaviour
{
    public GameObject ship; 

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ship, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(ship, new Vector3(2, 0, 2), Quaternion.identity);
        Instantiate(ship, new Vector3(-2, 0, 2), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
