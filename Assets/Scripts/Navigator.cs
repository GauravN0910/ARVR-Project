using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Navigator : MonoBehaviour
{
    public void NavigateToView(){
        SceneManager.LoadScene(2);
    }   

    public void NavigatorToMap(){
        SceneManager.LoadScene(1);
    }

    public void NavigateToInterior(){
        SceneManager.LoadScene(3);
    }

}
