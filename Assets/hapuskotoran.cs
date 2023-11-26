using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hapuskotoran : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "kotoran")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "kotoran")
        {
            Destroy(collision.gameObject);
        }
    }

}
