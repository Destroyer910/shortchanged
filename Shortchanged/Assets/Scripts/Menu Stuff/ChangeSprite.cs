using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{
    public void updateImage(Sprite newImage)
    {
        gameObject.GetComponent<Image>().sprite = newImage;
    }
}
