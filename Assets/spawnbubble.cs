using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnbubble : MonoBehaviour
{

    public GameObject[] bubble;
    public GameObject bubble1;
    public GameObject bubble2;
    public GameObject bubble3;
    public GameObject bubble4;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "spawn")
        {
            bubble1.SetActive(true);
            bubble2.SetActive(true);
            bubble3.SetActive(true);
            bubble4.SetActive(true);
            foreach (GameObject go in bubble)
            {
                go.SetActive(true);
            }

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "spawn")
        {
            bubble1.SetActive(true);
            bubble2.SetActive(true);
            bubble3.SetActive(true);
            bubble4.SetActive(true);
            bubble = GameObject.FindGameObjectsWithTag("bubble");
            foreach (GameObject go in bubble)
            {
                go.SetActive(true);
            }

        }
    }

}
