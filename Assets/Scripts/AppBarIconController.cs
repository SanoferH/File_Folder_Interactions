using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppBarIconController : MonoBehaviour
{
    public float xPosition;
    public float yPosition;
    public float zPosition;
    

    private void Awake()
    {
       // yPosition = transform.position.y;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
//        Debug.Log("transform : "+ transform.position);
       // transform.position = new Vector3(xPosition, yPosition, zPosition);

    }
}
