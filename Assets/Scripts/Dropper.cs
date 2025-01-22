using UnityEngine;


public class Dropper : MonoBehaviour
{  
    [SerializeField] float timeToWait = 2f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    private void Start() {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
    }

    void Update() {
        if(Time.time > timeToWait)
        {
            myMeshRenderer = GetComponent<MeshRenderer>();
            myMeshRenderer.enabled = true;
            myRigidbody = GetComponent<Rigidbody>();
            myRigidbody.useGravity = true;
        }
        
    }
}

