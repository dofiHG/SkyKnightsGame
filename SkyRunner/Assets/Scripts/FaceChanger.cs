using UnityEngine;
using UnityEngine.UI;

public class FaceChanger : MonoBehaviour
{
    private TrollCounter trollCounter;
    private Image trollFace;

    public Sprite[] spritesArray;


    private void Start()
    {
        trollCounter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TrollCounter>();
        trollFace = gameObject.GetComponent<Image>();
        trollFace.sprite = spritesArray[2];
    }

    private void Update()
    {
        switch(trollCounter.level)
        {
            case 1: trollFace.sprite = spritesArray[0]; break;
            case 2: 
                trollFace.sprite = spritesArray[1];
                trollFace.rectTransform.sizeDelta = new Vector2(506, 455);
                break;
            case 3: 
                trollFace.sprite = spritesArray[2];
                trollFace.rectTransform.sizeDelta = new Vector2(456, 405);
                break;
            case 4: 
                trollFace.sprite = spritesArray[3];
                trollFace.rectTransform.sizeDelta = new Vector2(456, 405);
                break;
            case 5: 
                trollFace.sprite = spritesArray[4];
                trollFace.rectTransform.sizeDelta = new Vector2(456, 405);
                break;
            case 6: 
                trollFace.sprite = spritesArray[5];
                trollFace.rectTransform.sizeDelta = new Vector2(456, 405);
                break;
            case 7: 
                trollFace.sprite = spritesArray[6];
                trollFace.rectTransform.sizeDelta = new Vector2(506, 455);
                break;
            case 8:
                trollFace.sprite = spritesArray[7];
                trollFace.rectTransform.sizeDelta = new Vector2(506, 455);
                break;
            case 9:
                trollFace.sprite = spritesArray[8];
                trollFace.rectTransform.sizeDelta = new Vector2(506, 455);
                break;
            case 10:
                trollFace.sprite = spritesArray[9];
                trollFace.rectTransform.sizeDelta = new Vector2(506, 455);
                break;
            case 11:
                trollFace.sprite = spritesArray[10];
                trollFace.rectTransform.sizeDelta = new Vector2(506, 455);
                break;
            case 12:
                trollFace.sprite = spritesArray[11];
                trollFace.rectTransform.sizeDelta = new Vector2(506, 455);
                break;
            case 13:
                trollFace.sprite = spritesArray[12];
                trollFace.rectTransform.sizeDelta = new Vector2(506, 455);
                break;
            case 14:
                trollFace.sprite = spritesArray[13];
                trollFace.rectTransform.sizeDelta = new Vector2(506, 455);
                break;

        }
    }
}
