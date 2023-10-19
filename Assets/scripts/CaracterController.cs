using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaracterController : MonoBehaviour
{
    
    public Animator animator;
    public Animator animatorEspelho;
    [SerializeField]
    private float speed; 
    public float movementSpeed = 3f;

    

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        
       

    }

    // Update is called once per frame
    void Update()
    {
        movementSpeed = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(movementSpeed));
        animatorEspelho.SetFloat("Speed", Mathf.Abs(movementSpeed));
        if (movementSpeed < 0) 
            transform.eulerAngles = new Vector3(0, -180, 0);
        if (movementSpeed  > 0)
            transform.eulerAngles = new Vector3(0, 0, 0);
        
        if (Input.GetKey("a"))
        {
            
            transform.position -= Vector3.left * movementSpeed * speed * Time.deltaTime;
            
        }
        if (Input.GetKey("d"))
        {
            
            transform.position += Vector3.right * movementSpeed *  speed * Time.deltaTime;
            
        }


    }
    

}
