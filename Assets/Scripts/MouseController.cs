using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    public Camera mainCam;
    public float speed;
    public ScoreControl score;
    // Update is called once per frame
    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector3 cursorPlayer = mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,1));
        Vector3 angle = cursorPlayer - transform.position;
        if (Vector3.Distance(cursorPlayer, transform.position) > 0.5)
        {
            transform.Translate(angle.normalized *speed* Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spawn")
        {
            score.IncrementScore();
            Destroy(collision.gameObject);          
        }
    }
}
