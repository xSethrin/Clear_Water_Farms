using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class PlayerController : MonoBehaviour{

public float speed = 10.4f;
public Animator animator;
public GameObject[] tools;

void Update(){
    
    Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
    animator.SetFloat("Horizontal", movement.x);
    animator.SetFloat("Vertical", movement.y);
    animator.SetFloat("Magnitude", movement.magnitude);
    transform.position = transform.position + movement * Time.deltaTime * 6;
    if(Input.GetKey("1")){
        JackObject.currentTool = "hand";
        //Inventory.GetComponent<Image>().color = selected;
        Debug.Log("Switched to hand");
    }
    if(Input.GetKey("2")){
        JackObject.currentTool = "water";
        Debug.Log("Switched to water");

        }
        if (Input.GetKey("3")){
        JackObject.currentTool = "hoe";
        Debug.Log("Switched to hoe");

        }
        if (Input.GetKey("4")){
        JackObject.currentTool = "sickle";
        Debug.Log("Switched to sickle");

        }

        if (Input.GetKey("5")){
        JackObject.currentTool = "hammer";
        Debug.Log("Switched to hammer");

        }

        if (Input.GetKey("6")){
        JackObject.currentTool = "axe";
        Debug.Log("Switched to axe");

        }
    }

    
    /**
    Vector3 pos = transform.position;


    if(Input.GetKey("w")){
        pos.y += speed * Time.deltaTime;
    }
    if(Input.GetKey("s")){
        pos.y -= speed * Time.deltaTime;
    }
    if(Input.GetKey("d")){
        pos.x += speed * Time.deltaTime;
    }
    if(Input.GetKey("a")){
        pos.x -= speed * Time.deltaTime;
    }
    transform.position = pos;
}
*/

/**

ALL THIS CODE IS WHAT WE HAD WHEN WE WERE USING A CONTOLLER

    private new Rigidbody2D rigidbody;
    Vector2 velocity;// = new Vector2();
    string buffer;
    public GameObject prefab;
    private SerialPort serial;
    public Animator animator;
    //public GameObject circle;
    // Start is called before the first frame update
    void Start(){
        serial = new SerialPort("COM4", 9600);
        serial.Open();  
        rigidbody = GetComponent<Rigidbody2D>();
        velocity = new Vector2(0,0);
        serial.ReadTimeout = 1;

    }

    // Update is called once per frame
    void Update(){
        //string state = serial.ReadLine();
        try{
            buffer += serial.ReadExisting();
            //SDebug.Log(buffer);
            int index0 = buffer.LastIndexOf(']');
            if(index0 >= 0){
                int index1 = buffer.LastIndexOf('[', index0);
                if(index1 >= 0){
                     string payload = buffer.Substring(index1 + 1, ((index0 - index1) - 1));
                    if(index0 == buffer.Length - 1){
                        buffer = "";
                    }
                    else{
                        buffer = buffer.Substring(index0 + 1);
                    }
                   // Debug.Log(payload);
                    string[] tokens = payload.Split(' ');
                    int x, y;// z;
                    int.TryParse(tokens[0], out x);
                    int.TryParse(tokens[1], out y);
                    //int.TryParse(tokens[2], out z);
                    if (Mathf.Abs(x) < 10) x = 0;
                    if (Mathf.Abs(y) < 10) y = 0;
                    velocity = (0.3f * velocity) + ((new Vector2(x, y) / 100f) * 0.7f);
                    rigidbody.velocity = velocity;
                    animator.SetInteger("x", x);
                    animator.SetInteger("y", y);
                    Debug.Log(payload);
                    if(x > 0 && x >= y){
                        animator.SetBool("right", true);
                    }
                    else if(x < 0 && x <= y){
                        animator.SetBool("left", true);
                    }
                    else if(y > 0){
                        animator.SetBool("up", true);
                    }
                    else if(y < 0){
                        animator.SetBool("down", true);
                    }
                    else{
                        animator.SetBool("right", false);
                        animator.SetBool("left", false);
                        animator.SetBool("up", false);
                        animator.SetBool("down", false);
                    }
                    
                }  
      
            }
            else{
                buffer = "";
                animator.SetBool("right", false);
                animator.SetBool("left", false);
                animator.SetBool("up", false);
                animator.SetBool("down", false);
            }
        }
        catch (System.TimeoutException) {
        }
    }

    void OnTriggerEnter2D(Collider2D collider){
       Destroy(collider.gameObject);

    }
    */
}
