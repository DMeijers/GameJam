using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 moveDir;
    public Animator animator;
    internal object body;


    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDir = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")).normalized;
        
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("IsMoving", true);
        }

        else
        {
            animator.SetBool("IsMoving", false);
          
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("GoingLeft", true);
        }
        else
        {

         animator.SetBool("GoingLeft", false);

        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("GoingRight", true);
        }
        else
        {

            animator.SetBool("GoingRight", false);

        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("GoingBack", true);
        }
        else
        {

            animator.SetBool("GoingBack", false);

        }

    }

    void FixedUpdate(){
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDir) * speed * Time.deltaTime);

    }
}
