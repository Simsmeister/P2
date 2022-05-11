using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesButton : MonoBehaviour
{
[SerializeField] GameObject guideMenu;
[SerializeField] GameObject guideMenuTwo;
[SerializeField] GameObject guideMenuThree;
[SerializeField] GameObject guideMenuFour;
 
    public void Closer()
    {
    guideMenu.SetActive(false);
    guideMenuTwo.SetActive(false);
    guideMenuThree.SetActive(false);
    
    }
}
