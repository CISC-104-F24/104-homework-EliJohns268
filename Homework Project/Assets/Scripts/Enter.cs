using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColENter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f);




    }
}
