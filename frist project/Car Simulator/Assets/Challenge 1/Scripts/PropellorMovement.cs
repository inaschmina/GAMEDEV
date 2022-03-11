using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellorMovement : MonoBehaviour
{
    public GameObject propellor;
    private float speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);

    }
}
