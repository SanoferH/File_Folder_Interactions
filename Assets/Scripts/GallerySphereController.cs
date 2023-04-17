using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GallerySphereController : MonoBehaviour
{
    private bool entered = false;

    [SerializeField] private GallerySphereIdentifier _gallerySphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<GallerySphereIdentifier>())
        {
            _gallerySphere.canOpenMemory = true;
        }
    }

}
