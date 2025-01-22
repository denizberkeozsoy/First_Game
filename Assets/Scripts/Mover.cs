using UnityEngine;

public class Mover : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstruction();
        transform.Translate(1,0,0);
    }
    [SerializeField] float moveSpeed = 25;
    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction(){
        Debug.Log("Welcome to game");
        Debug.Log("to game");
    }
    
    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
        
    }
}
