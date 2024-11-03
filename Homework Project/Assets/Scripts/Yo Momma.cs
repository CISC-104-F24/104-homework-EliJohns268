using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoMomma : MonoBehaviour
{
    public Vector3 newScale = new Vector3(10, 10, 10);

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
        transform.localScale = newScale;

    }

}
