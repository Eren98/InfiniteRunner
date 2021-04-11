using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private float speed = 30;
    private Test testScript;
    private float leftBound = -15f;

    // Start is called before the first frame update
    void Start()
    {
        testScript = GameObject.Find("Player").GetComponent<Test>();
    }

    // Update is called once per frame
    void Update()
    {
        if (testScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
