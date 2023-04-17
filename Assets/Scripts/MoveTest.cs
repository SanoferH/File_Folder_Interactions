using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    public float yPosition;

    [SerializeField] private Transform _centreEyeCamera;
    // Start is called before the first frame update
    void Start()
    {
        yPosition = 1.12f;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = _centreEyeCamera.position;
        //transform.rotation = _centreEyeCamera.rotation;

        transform.position = new Vector3(_centreEyeCamera.position.x, yPosition, _centreEyeCamera.position.z);
        transform.rotation = Quaternion.Euler(_centreEyeCamera.rotation.x, _centreEyeCamera.rotation.y,
            _centreEyeCamera.rotation.z);
    }
}
