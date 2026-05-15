using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public List<Item> objetos;
    public RectTransform content;
    public GameObject itemUIPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        content.sizeDelta = new Vector2(0,50);
        for (int i = 0;  i < objetos.Count; i++)
        {
            GameObject uiItemClone = Instantiate(itemUIPrefab, content);
            uiItemClone.transform.GetChild(0).GetComponent<Image>().sprite = objetos[i].objectImage;
            uiItemClone.transform.GetChild(1).GetComponent<Text>().text = objetos[i].name;
            switch(objetos[i].objectType)
            {
                case Item.ObjectType.Weapon:
                    uiItemClone.transform.GetChild(2).GetComponent<Text>().text = "Ataque: ";
                    break;
                case Item.ObjectType.Armor:
                    uiItemClone.transform.GetChild(2).GetComponent<Text>().text = "Defensa: ";
                    break;
                case Item.ObjectType.Consumable:
                    uiItemClone.transform.GetChild(2).GetComponent<Text>().text = "Curación: ";
                    break;      
            }
            uiItemClone.transform.GetChild(2).GetComponent<Text>().text += objetos[i].value.ToString();
            
            content.sizeDelta += new Vector2(0, uiItemClone.GetComponent<RectTransform>().sizeDelta.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
