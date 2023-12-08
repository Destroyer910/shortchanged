using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PassCodeLock : MonoBehaviour
{
    private int num1;
    public int num1Req;
    private int num2;
    public int num2Req;
    private int num3;
    public int num3Req;
    private int num4;
    public int num4Req;
    public GameObject activator;
    public TMP_Text num1Text;
    public TMP_Text num2Text;
    public TMP_Text num3Text;
    public TMP_Text num4Text;

    public void upNum1()
    {
        if(num1 + 1 > 9)
        {
            num1 = 0;
        }
        else
        {
            num1++;
        }
        num1Text.text = "" + num1;
    }
    public void downNum1()
    {
        if(num1 - 1 <0)
        {
            num1 = 9;
        }
        else
        {
            num1--;
        }
        num1Text.text = "" + num1;
    }
    public void upNum2()
    {
        if(num2 + 1 > 9)
        {
            num2 = 0;
        }
        else
        {
            num2++;
        }
        num2Text.text = "" + num2;
    }
    public void downNum2()
    {
        if(num2 - 1 <0)
        {
            num2 = 9;
        }
        else
        {
            num2--;
        }
        num2Text.text = "" + num2;
    }
    public void upNum3()
    {
        if(num3 + 1 > 9)
        {
            num3 = 0;
        }
        else
        {
            num3++;
        }
        num3Text.text = "" + num3;
    }
    public void downNum3()
    {
        if(num3 - 1 <0)
        {
            num3 = 9;
        }
        else
        {
            num3--;
        }
        num3Text.text = "" + num3;
    }
    public void upNum4()
    {
        if(num4 + 1 > 9)
        {
            num4 = 0;
        }
        else
        {
            num4++;
        }
        num4Text.text = "" + num4;
    }
    public void downNum4()
    {
        if(num4 - 1 <0)
        {
            num4 = 9;
        }
        else
        {
            num4--;
        }
        num4Text.text = "" + num4;
    }

    public void activateGame(GameObject objectActivator, int req1, int req2, int req3, int req4)
    {
        num1Req = req1;
        num2Req = req2;
        num3Req = req3;
        num4Req = req4;
        activator = objectActivator;
        gameObject.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
    }

    public void checkCode()
    {
        if(num1 == num1Req && num2 == num2Req && num3 == num3Req && num4 == num4Req)
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            activator.GetComponent<DisableManager>().disableObject(true);
            gameObject.SetActive(false);
        }
        else
        {
            //Add code to do detection level thing
        }
    }
}
