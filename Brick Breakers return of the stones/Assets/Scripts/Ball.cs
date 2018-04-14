using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Paddle paddle;
    private bool hasStarted = false;
    public float thrust;
    private Vector3 paddletoBallVector;

	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();

        paddletoBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddletoBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 15f);

            }
        }
	}

    void OnCollisionEnter2D(Collision2D col)
    {

        Vector2 tweak = new Vector2(Random.Range(0f, 1f), Random.Range(0f, 1f));

        if (hasStarted == true)
        {
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }
}
