using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prct3_Ej9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col) {
        Debug.Log(col.gameObject.name);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }

}
