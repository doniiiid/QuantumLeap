using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovementFollow : MonoBehaviour
{
    public float speed; //fast boy
    private Transform target; //chasing player
    public float distanceFromPlayer = 3;

    void Start(){

        //finding the position of whatever has the tag player
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        
    }

    IEnumerator WaitAFew(){
        //waiting so the enemy doesnt follow right away
         yield return new WaitForSeconds(0.3f);
         //flips direction of the enemy to follow in another direction
        if(target.position.x > transform.position.x){
            transform.localScale = new Vector3(-4f,4f,1f);
            Vector3 currRot = transform.eulerAngles;
            //transform.localxscale = -1;
        }else{
            transform.localScale = new Vector3(4f,4f,1f);

        }
        //move towards player 
        if(Vector2.Distance(transform.position, target.position) > distanceFromPlayer){
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    void Update(){
        StartCoroutine(WaitAFew());
    }




//     public LayerMask enemyMask;
//     Rigidbody2D myBody;
//     Transform myTrans;
//     float myWidth;
//     public float speed;
//     // Start is called before the first frame update
//     void Start()
//     {
//         myTrans = this.transform;
//         myBody = this.GetComponent<Rigidbody2D>();
//         myWidth = this.GetComponent<SpriteRenderer>().bounds.extents.x;

        
//     }

//     // Update is called once per frame
//     void FixedUpdate()
//     {
//         //checking to see if there is a ground infront of it before moving forward.
//         Vector2 lineCastPos = myTrans.position - myTrans.right * myWidth;
//         bool isGrounded = Physics2D.Linecast(lineCastPos, lineCastPos + Vector2.down, enemyMask);
//         //if not grounded then we will turn the enemy
//         if(!isGrounded){
//             Vector3 currRot = myTrans.eulerAngles;
//             currRot.y+=180;
//             myTrans.eulerAngles = currRot;
//         }


//         //always move forward
//         Vector2 myVel = myBody.velocity;
//         myVel.x = -speed;
//         myBody.velocity = myVel; //can change the velocity

        
//     }
}
