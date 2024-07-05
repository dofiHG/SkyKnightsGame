using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class SetActieLvLs : MonoBehaviour
{
    private void Start()
    {
        int i = 0;
        
        foreach (Transform obj in transform.GetComponentsInChildren<Transform>())
        {
            if (obj.name.Substring(0, 2) == "Te") 
            {
                if (Int32.Parse(obj.GetComponent<TMP_Text>().text) % 10 == 0) { obj.gameObject.GetComponent<TMP_Text>().color = new Color(164, 0, 0); }
                else { obj.gameObject.GetComponent<TMP_Text>().color = new Color(123, 123, 123); }
                i++;
            }
            
            if (i == YandexGame.savesData.activeLvls) { break; }

            if (obj.name.Substring(0, 2) == "Le") { obj.gameObject.GetComponent<Image>().color = new Color(255, 255, 255);}
        }
    }
}
