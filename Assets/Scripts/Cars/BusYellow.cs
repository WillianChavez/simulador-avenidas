using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusYellow : MonoBehaviour
{
    [SerializeField]
    public float speed = 1.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement(){
        // Mueve el objeto hacia adelante en el eje Z
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
