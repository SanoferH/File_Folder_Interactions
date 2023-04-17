using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class HighLighter : MonoBehaviour
{
    [SerializeField] Graphic home_Graphic;
    [SerializeField] Graphic gallery_Graphic;
    Color home_Color; 
    Color gallery_Color; 
    // Start is called before the first frame update
    void Start()
    {
        home_Color = home_Graphic.color;
        gallery_Color = gallery_Graphic.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Button]
    public void MoveHighLighterToHome()
    {
        LeanTween.move(gameObject.GetComponent<RectTransform>(), new Vector3(-21.0f, 14.64f, 0), 0.3f);
        LeanTween.color(gameObject.GetComponent<RectTransform>(), home_Color, 0.3f);
    }
    [Button]
    public void MoveHighLighterToGallery()
    {
        LeanTween.move(gameObject.GetComponent<RectTransform>(), new Vector3(0.85f, 16.75f, 0), 0.3f);
        LeanTween.color(gameObject.GetComponent<RectTransform>(), gallery_Color, 0.3f);
    }
}
