using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI系の部品を使う際に必要
using UnityEngine.UI;
//TextMeshProを使う際に必要
using TMPro;

public class CubeTest : MonoBehaviour
{
    public TextMeshProUGUI text;
    public void OnPointerClick()
    {
        text.text = "Cubeをクリックしました";
    }
}