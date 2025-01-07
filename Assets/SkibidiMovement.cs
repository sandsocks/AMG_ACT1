using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkibidiMovement : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;
        this.transform.position += direction;

    }
}
