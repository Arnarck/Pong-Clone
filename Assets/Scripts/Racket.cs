using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public bool isRightSide;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRightSide)
        {
            transform.Translate(Vector3.up * Input.GetAxis("Vertical2") * Speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.up * Input.GetAxis("Vertical") * Speed * Time.deltaTime);
        }

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.8f, 3.8f), transform.position.z);
    }
}
