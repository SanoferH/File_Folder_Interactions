using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class AppBarAnimation : MonoBehaviour
{
    [SerializeField] private UnityEngine.GameObject _appBar;
    [SerializeField] private UnityEngine.GameObject _appBarIcon;
    
    
    public bool canShowAppBar;

    public bool isUsingAppBar;
    // Start is called before the first frame update
    void Start()
    {
        _appBar.SetActive(false);
        canShowAppBar = false;
        isUsingAppBar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canShowAppBar)
        {
            ShowAppBar();
        }
        else
        {
            if (!isUsingAppBar)
            {
                HideAppBar();
            }
            
        }
    }

    public void UsingAppBar()
    {
        isUsingAppBar = true;
    }

    [Button]
    public void ShowAppBar()
    {
        _appBarIcon.SetActive(false);
        _appBar.SetActive(true);
        LeanTween.scale(_appBar, new Vector3(3, 3, 3), 0.6f).setEase(LeanTweenType.easeOutQuad);
      //  LeanTween.moveLocal(gameObject, new Vector3(0f,-0.1315f,0.3676f), 0.6f) .setEase( LeanTweenType.easeOutQuad );
       // LeanTween.scale(_appBarIcon, new Vector3(3, 3, 3), 0.6f).setEase(LeanTweenType.easeOutQuad);
       // LeanTween.alpha(_appBarIconCanvas.GetComponent<RectTransform>(), 0.0f, 0.6f);
       // LeanTween.alphaCanvas(_appBarIconCanvas, 0.0f, 0.6f);
       // LeanTween.alpha(gameObject.GetComponent<RectTransform>(), 0.0f, 0.3f);
        
      //  LeanTween.rotateX(gameObject, 65.0f,0.6f).setEase(LeanTweenType.easeOutQuad);
    }

    [Button]
    public void HideAppBar()
    {
       // _appBar.SetActive(false);
        LeanTween.scale(_appBar, new Vector3(1, 1, 1), 0.8f).setEase(LeanTweenType.easeOutQuad);
        StartCoroutine(HideTheAppBar());
    }

    IEnumerator HideTheAppBar()
    {
        yield return new WaitForSeconds(.7f);
        _appBar.SetActive(false);
        _appBarIcon.SetActive(true);
    }
}
