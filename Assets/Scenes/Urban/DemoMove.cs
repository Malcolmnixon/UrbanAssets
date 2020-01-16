using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoMove : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float RotateSpeed = 90f;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -RotateSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, RotateSpeed * Time.deltaTime, 0);
        }

        if (Input.GetMouseButton(0))
        {
            var halfWidth = (Screen.width / 2);
            var halfHeight = (Screen.height / 2);

            var amountX = (Input.mousePosition.x - halfWidth) / halfWidth;
            var amountY = (Input.mousePosition.y - halfHeight) / halfHeight;

            var newX = amountX * RotateSpeed * Time.deltaTime;
            var newZ = amountY * MoveSpeed * Time.deltaTime;

            transform.Rotate(0, newX, 0);
            transform.Translate(0, 0, newZ);
        }
    }
}
