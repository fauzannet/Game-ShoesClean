using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectmove : MonoBehaviour
{
    public float speed = 1f;
    private Vector3 targetPosition;
    private Vector3 touchPosition;
    private Vector3 defaultPosition;
    private Vector3 direction;
    private Vector3 offset;
    private Vector3 screenPoint;
    private float moveSpeed = 10f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        defaultPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    public void MoveTo(Vector3 position)
    {
        targetPosition = position;
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * moveSpeed;

            if (touch.phase == TouchPhase.Ended)
            gameObject.transform.position = defaultPosition;
        }
}
}
