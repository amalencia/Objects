using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Camera mainCamera;
    private Player myPlayer;
    public Vector2 direction;
    public float angleToRotate;

    //Start is called before the first frame update
    private void Start()
    {
        myPlayer = GetComponent<Player>();
    }

    //Update is called once per frame
    private void Update()
    {
        //float horizontalInput = Input.GetAxisRaw("Horizontal");
        //float verticalInput = Input.GetAxisRaw("Vertical");

        // myPlayer.Move(new Vector2(horizontalInput, verticalInput));
        if (Input.GetMouseButtonDown(0))
        {
            myPlayer.Attack();
        }
    }

    //Fixed Update is better for physics
    private void FixedUpdate()
    {
        //Receiving input from the keyboard
        float horizontalInput = Input.GetAxisRaw("Horizontal");  //could also use GetAxis
        float verticalInput = Input.GetAxisRaw("Vertical");

        
        direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)); ;
        angleToRotate = Mathf.Atan2(direction.y - transform.position.y, direction.x- transform.position.x) * Mathf.Rad2Deg;

        //sending the input as coordinates to the player script (Move)
        myPlayer.Move(new Vector2(horizontalInput, verticalInput), angleToRotate);


    }
}
