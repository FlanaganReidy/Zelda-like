using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 newMinPosition;
    public Vector2 newMaxPosition;
    public Vector3 playerMove;
    private cameraMovement cam;
    void Start()
    {
        cam = Camera.main.GetComponent<cameraMovement>();
    }

    // Update is called once per 
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            cam.minPosition = newMinPosition;
            cam.maxPosition = newMaxPosition;
            other.transform.position += playerMove;
        }
    }

}
