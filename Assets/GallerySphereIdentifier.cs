using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GallerySphereIdentifier : MonoBehaviour
{
    public bool canOpenMemory;
    // Start is called before the first frame update
    void Start()
    {
        canOpenMemory = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canOpenMemory)
        {
            Debug.Log(transform.localPosition);
            LeanTween.scale(gameObject, new Vector3(350.0f, 350.0f, 350.0f), 0.2f).setDestroyOnComplete(true);
        }
    }
}
