using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float min = 0f;
    public float max = 13f;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        MoveWithMouse();
	}

    void MoveWithMouse()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, this.transform.position.y);
        Vector2 objPos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.x = Mathf.Clamp(objPos.x, min, max);
        transform.position = mousePos;
    }

}
