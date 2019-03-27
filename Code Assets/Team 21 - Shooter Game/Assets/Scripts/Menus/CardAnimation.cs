using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardAnimation : MonoBehaviour
{
    Animator Animation;

    private Button card;
    public Sprite Highlighted;
    private Sprite Original;
    

	// Use this for initialization
	void Start ()
    {
        Animation = gameObject.GetComponent<Animator>();
        card = GetComponent<Button>();

        Original = gameObject.GetComponent<Image>().sprite;


	}
	
	// Update is called once per frame
	void Update ()
    {
        OnMouseEnter();
        OnMouseExit();
	}

    private void OnMouseEnter()
    {
        Animation.SetTrigger("Card Hover");
        card.image.sprite = Highlighted;
    }

    private void OnMouseExit()
    {
        Animation.ResetTrigger("Card Hover");
        card.image.sprite = Original;

    }
}
