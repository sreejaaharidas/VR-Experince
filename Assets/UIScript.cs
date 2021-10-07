using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{
    // Start is called before the first frame update
   
     public TextMeshProUGUI simpleUIText;

     public void OnEnterGameClicked()
    {
        simpleUIText.text = "ComeOn and try to escape soon!!!";
    }

    public void OnExitGameClicked()
    {
        simpleUIText.text = "Oops! Out of the game";
    }

}

 

