using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterLocation : MonoBehaviour
{
    public string location;
    public bool player;

    void Start()
    {
        location = transform.parent.name;
    }

    void Update()
    {
        if(player && Input.GetKeyDown(KeyCode.E))
        {
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().canMove == true)
            {
                GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().SetReturnLocation(transform.position);
                GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().ChangeScene(location);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
            player = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
            player = false;
        }
    }


}
