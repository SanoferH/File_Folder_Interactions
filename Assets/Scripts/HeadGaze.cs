using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadGaze : MonoBehaviour
{
    [SerializeField] private UnityEngine.GameObject AppBarIcon;

    [SerializeField] private AppBarAnimation _appBarAnimation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,
                Mathf.Infinity))
        {
            if (hit.collider.GetComponent<AppIconIdentifier>())
            {
                _appBarAnimation.canShowAppBar = true;
            }
            else
            {
                _appBarAnimation.canShowAppBar = false;
            }
        }
    }
}
