using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class PlayerController : MonoBehaviour{

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
                    /*
                    if(z == 1){
                        GameObject instance = Instantiate(prefab, transform.position, Quaternion.identity);
                        Rigidbody2D thiccBody = instance.GetComponent<Rigidbody2D>();
                        thiccBody.AddForce(new Vector3(500, 500, 0));
                    }
                    */
                    
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
}
