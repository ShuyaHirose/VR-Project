using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI�n�̕��i���g���ۂɕK�v
using UnityEngine.UI;
//TextMeshPro���g���ۂɕK�v
using TMPro;

public class CubeTest : MonoBehaviour
{
    public TextMeshProUGUI text;
    public void OnPointerClick()
    {
        text.text = "Cube���N���b�N���܂���";
    }
}