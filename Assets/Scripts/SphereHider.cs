using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereHider : MonoBehaviour
{

    [SerializeField] private GameObject Sphere1;
    [SerializeField] private GameObject Sphere2;
    [SerializeField] private GameObject Sphere3;
    [SerializeField] private GameObject Sphere4;
    [SerializeField] private GameObject Sphere5;
    [SerializeField] private GameObject Sphere6;
    [SerializeField] private GameObject Sphere7;
    [SerializeField] private GameObject Sphere8;
    [SerializeField] private GameObject Sphere9;

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
        if (other.tag == "Sphere")
        {
           other.GetComponent<SphereAnimator>().ShrinkSphere();
           
           Debug.Log("Entereddddddddddddddd: "+other.gameObject.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Sphere")
        {
            other.GetComponent<SphereAnimator>().ExpandSphere();
        }
    }
}
