using UnityEngine;
using UnityEngine.UIElements;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 15;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Awake() {
        gameObject.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;      
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer(){
        transform.position = 
        Vector3.MoveTowards(transform.position, playerPosition,  speed * Time.deltaTime );

    }

    void DestroyWhenReached(){
        if(transform.position == playerPosition){
        Destroy(gameObject);
        }
    }
}
