using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigEnemy : MonoBehaviour
{
    private Rigidbody2D pigRigidbody;
    [SerializeField] GameObject nextLevelUI = null;

    void Start()
    {
        pigRigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

        else if (collision.gameObject.tag == "Brick")
        {
            if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude >= 1)
            {
                nextLevelUI.SetActive(true);
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.tag == "Wall")
        {
            nextLevelUI.SetActive(true);
            Destroy(gameObject);
        }
    }
}