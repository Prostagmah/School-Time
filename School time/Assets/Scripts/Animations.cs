using UnityEngine.UI;
using UnityEngine;

public class Animations : MonoBehaviour
{
    private bool Check = true;
    public GameObject ShopPan2;
    public GameObject ShopPan;
    public void OnClickArrows()
    {
        if(Check == true)
        {
            ShopPan2.SetActive(true);
            ShopPan.SetActive(false);
            Check = false;
        }
        else
        {
            ShopPan.SetActive(true);
            ShopPan2.SetActive(false);
            Check = true;
        }
    }
}
