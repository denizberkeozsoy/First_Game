using UnityEngine;

public class FlyAtPlayer3 : MonoBehaviour
{
    [SerializeField] float timeToWait = 20.5f;
    [SerializeField] float speed = 15;
    [SerializeField] Transform player;
    Vector3 playerPosition;




    // Update is called once per frame
    void Update()
    {
    if (Time.time > timeToWait && playerPosition == Vector3.zero)
    {
        // Capture the player's position once
        playerPosition = player.transform.position;
    }

    // Move toward the captured player position
    if (playerPosition != Vector3.zero)
    {
        MoveToPlayer();
    }

    DestroyWhenReached();
    }

    
    void DestroyWhenReached(){
        if(transform.position == playerPosition){
        Destroy(gameObject);
        }
    }

    void MoveToPlayer(){
        transform.position = 
        Vector3.MoveTowards(transform.position, playerPosition,  speed * Time.deltaTime );

    }
}
