using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeOf : MonoBehaviour
{
    [SerializeField]
    private Image image;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(FadeOut());
    }

    private IEnumerator FadeOut()
    {
        float alpha = 1.0f;
        Color colorImagen = image.color;
        while (alpha >0)
        {
            alpha -= 0.05f;
            colorImagen.a = alpha;
            image.color = colorImagen;
            yield return null;
        } 
    }
}
