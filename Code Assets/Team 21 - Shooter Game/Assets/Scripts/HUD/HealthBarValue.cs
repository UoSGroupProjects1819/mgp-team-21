using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBarValue : MonoBehaviour {

    private string formatText = "{0}";

    private TextMeshProUGUI tmproText;

	// Use this for initialization
	private void Start ()
    {
        tmproText = GetComponent<TextMeshProUGUI>();

        GetComponentInParent<Slider>().onValueChanged.AddListener(HandleValueChanged);
	}

    private void HandleValueChanged(float value)
    {
        tmproText.text = string.Format(formatText, value);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
