using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ChangeObject2 : MonoBehaviour
{
    //public GameObject cube;
    //public GameObject sphere;
    //public GameObject cylinder;
    public GameObject size_std;
    public GameObject size_cha;
    public GameObject size_mid;
    public GameObject pos_std;
    public GameObject pos_mid;
    public GameObject pos_low;
    public int count;
 
    void Start()
    {
        count = 1;
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            count++;
            if(count > 6){
                count = 1;
            }
        }
 
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            count--;
            if(count < 1){
                count = 6;
            }
        }
 
        if(count == 1){
            size_std.SetActive(true);
            size_cha.SetActive(false);
            size_mid.SetActive(false);
            pos_std.SetActive(false);
            pos_mid.SetActive(false);
            pos_low.SetActive(false);
        }
 
        if(count == 2){
            size_std.SetActive(false);
            size_cha.SetActive(true);
            size_mid.SetActive(false);
            pos_std.SetActive(false);
            pos_mid.SetActive(false);
            pos_low.SetActive(false);
        }
 
        if(count == 3){
            size_std.SetActive(false);
            size_cha.SetActive(false);
            size_mid.SetActive(true);
            pos_std.SetActive(false);
            pos_mid.SetActive(false);
            pos_low.SetActive(false);
        }

        if(count == 4){
            size_std.SetActive(false);
            size_cha.SetActive(false);
            size_mid.SetActive(false);
            pos_std.SetActive(true);
            pos_mid.SetActive(false);
            pos_low.SetActive(false);
        }

        if(count == 5){
            size_std.SetActive(false);
            size_cha.SetActive(false);
            size_mid.SetActive(false);
            pos_std.SetActive(false);
            pos_mid.SetActive(true);
            pos_low.SetActive(false);
        }
        if (count == 6)
        {
            size_std.SetActive(false);
            size_cha.SetActive(false);
            size_mid.SetActive(false);
            pos_std.SetActive(false);
            pos_mid.SetActive(false);
            pos_low.SetActive(true);
        }
    }
}