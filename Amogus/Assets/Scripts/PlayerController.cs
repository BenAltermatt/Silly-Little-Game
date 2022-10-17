using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed;

    [SerializeField]
    private float jumpStr;

    private bool grounded;

    [SerializeField]
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This is called at constant intervals
    void FixedUpdate() {
        Vector2 oldV = rb.velocity;

        float xIn = Input.GetAxisRaw("Horizontal");
        float xVec = 0;
        if(xIn < 0) {
            xVec = speed * -1;
        }
        if(xIn > 0) {
            xVec = speed;
        }

        float yVec = oldV.y;

        if(grounded && Input.GetAxisRaw("Jump") > 0){
            yVec = jumpStr;
        }

        rb.velocity = new Vector2(xVec, yVec);
    }

    void OnTriggerEnter2D(Collider2D collision) {
        grounded = true;
    }

    void OnTriggerExit2D(Collider2D collision) {
        grounded = false;
    }

}
