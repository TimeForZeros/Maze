using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
   // public Text countText;
    public Text winText;

    private Rigidbody2D rb2d;
   // private int count;

   // const int NUMOFITEMS = 1;

    // Start is called before the first frame update
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        winText.text = "";
       // count = 0;
       // SetCountText();



    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);
            winText.text = "Text";

            //count = count + 1;
            //  SetCountText();
        }
    }

   /* void SetCountText()
    {
        //countText.text = "Count: " + count.ToString();
        if (count>= NUMOFITEMS)
        {
            winText.text = "Text";
        }
    }*/
}