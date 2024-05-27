using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    private float movementX;

    // Update is called once per frame
    void Update()
    {
        movementX = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * movementX * speed * Time.deltaTime;

        // Clamping the position to keep the player within -7.9 and 7.9 on the x-axis
        float clampedX = Mathf.Clamp(transform.position.x, -7.9f, 7.9f);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}
