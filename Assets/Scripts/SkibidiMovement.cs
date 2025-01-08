using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkibidiMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        float length = Mathf.Sqrt(moveX * moveX + moveY * moveY);
        
        if (length > 0)
        {
            moveX /= length;
            moveY /= length;
        }

         transform.position += new Vector3(moveX, moveY, 0) * speed * Time.deltaTime;
    }
}
