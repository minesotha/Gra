using UnityEngine;
using System.Collections;

public class mouseOverObject : MonoBehaviour {
    SpriteRenderer sprite;
    GameObject childText;

    void Start()
    {
        sprite = this.GetComponent<SpriteRenderer>();
        GetTextChild();
    }

    void OnMouseEnter()
    {
        sprite.color = Color.red;
        childText.SetActive(true);
    }
    void OnMouseExit()
    {
        sprite.color = Color.white;
        childText.SetActive(false);
    }


    void GetTextChild()
    {
        foreach (Transform child in transform)
        {
            if (child.gameObject.tag == "textBubble")
            {
                childText = child.gameObject;
            }
        }
    }

}
