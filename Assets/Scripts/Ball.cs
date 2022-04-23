using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed;
    public GameObject racketCollision;

    // Start is called before the first frame update
    void Start()
    {
        float Vx = Random.Range(0, 2) == 0? -1 : 1;
        float Vy = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody2D>().velocity = new Vector2(Vx, Vy) * Speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.name == "LeftRacket")
        {
            Instantiate(racketCollision, transform.position, Quaternion.Euler(0f, 90f, 0f));
        }
        else if (other.gameObject.name == "RightRacket")
        {
            Instantiate(racketCollision, transform.position, Quaternion.Euler(0f, -90f, 0f));
        }
    }
}
