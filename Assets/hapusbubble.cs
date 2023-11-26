using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hapusbubble : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "bubble")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "bubble")
        {
            Destroy(collision.gameObject);
        }
    }

}
