using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 moveDir;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();    
    }

    private void Awake()
    {
        animator.Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        moveDir = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")).normalized;
        
        
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("IsMoving", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("GoingLeft", true);
        }

        else
        {
            animator.SetBool("IsMoving", false);
            animator.SetBool("GoingLeft", false);
        }
        


    }

    void FixedUpdate(){
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDir) * speed * Time.deltaTime);

    }
}
