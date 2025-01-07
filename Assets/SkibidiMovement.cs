using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkibidiMovement : MonoBehaviour
{
    [SerializeField] private Transform target;
    private float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Time.deltaTime * speed;
        this.transform.position += direction;

    }
}
