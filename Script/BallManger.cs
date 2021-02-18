using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallManger : MonoBehaviour
{
    float speed = 3.2f;
    public bool sagYon = true;
    private Vector3 stageDimensions;
    float topyarıcap = 0.42f;
    [SerializeField]
    Text PuanText;
    int puan;
    private void Awake()
    {

    }
    void Start()
    {
        stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        //Debug.Log(stageDimensions);
        PuanText.text = puan.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sagYon = !sagYon;
        }


        if (transform.position.x >= stageDimensions.x - topyarıcap)
        {
            sagYon = false;

        }
        else if (transform.position.x <= -stageDimensions.x + topyarıcap)
        {
            sagYon = true;
        }
        if (sagYon)
        {
            transform.position = new Vector2(transform.position.x + Time.deltaTime * speed, transform.position.y);
        }
        else if (!sagYon)
        {
            transform.position = new Vector2(transform.position.x - Time.deltaTime * speed, transform.position.y);
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "altin")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            puan++;
            PuanText.text = puan.ToString();

        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "engel")
        {
            Debug.Log("1ee");
        }
    }
}
