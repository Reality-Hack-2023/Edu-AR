using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayText : MonoBehaviour
{
    public TMP_Text defText;
    // Start is called before the first frame update
    void Start()
    {
        defText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ShowText()
    {
        Debug.Log("button clicked");
        defText.enabled = true;
    }
}
