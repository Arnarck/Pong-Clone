using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    public Text leftPointsText;
    public Text rightPointsText;

    public GameObject ballPrefab;
    public GameObject ballExplosion;

    public bool isRightSide;

    public float timeToSpawnBall;

    private int rightPoints = 0;
    private int leftPoints = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (this.name == "LeftCollider")
            {
                rightPoints++;
                rightPointsText.text = rightPoints.ToString();

                Instantiate(ballExplosion, other.transform.position, Quaternion.Euler(0f, 90f, 0f));
            }
            else if (this.name == "RightCollider")
            {
                leftPoints++;
                leftPointsText.text = leftPoints.ToString();

                Instantiate(ballExplosion, other.transform.position, Quaternion.Euler(0f, -90f, 0f));
            }

            Destroy(other.gameObject);
            StartCoroutine("RespawnBall");
        }
    }

    private IEnumerator RespawnBall()
    {
        yield return new WaitForSeconds(timeToSpawnBall);
        Instantiate(ballPrefab, Vector2.zero, Quaternion.identity);
    }
}
