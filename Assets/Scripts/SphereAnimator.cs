using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShrinkSphere()
    {
        LeanTween.scale(gameObject, new Vector3(0.0f, 0.0f, 0.0f), 0.2f);
    }

    public void ExpandSphere()
    {
        LeanTween.scale(gameObject, new Vector3(51.71f, 51.71f, 51.71f), 0.2f);
    }
}
