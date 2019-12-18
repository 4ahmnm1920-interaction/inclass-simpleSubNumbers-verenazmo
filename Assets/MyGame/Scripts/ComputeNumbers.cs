using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public Text result;
    public InputField ipfVarA;
    public InputField ipfVarB;
    public Button btnSubNumbers;
    public Button btnReset;

    private void Start()
    {
        btnReset.interactable = false;
    }

    public void SubNumbersOnClick()
    {
        /*index++;
        Debug.Log("onClick" + index);
        Debug.Log("input Field A text is " + ipfVarA.text);
        Debug.Log("input Field B text is " + ipfVarB.text);*/
        int variableA = int.Parse(ipfVarA.text);
        int variableB = int.Parse(ipfVarB.text);
        int Subresult = variableA - variableB;
        //Debug.Log("result " + (variableA - variableB));
        result.text = Subresult.ToString();
        ipfVarA.interactable = false;
        ipfVarB.interactable = false;
        btnSubNumbers.interactable = false;
        btnReset.interactable = true;

    }

    public void ResetOnClick()
    {
        ipfVarA.interactable = true;
        ipfVarB.interactable = true;
        btnSubNumbers.interactable = true;
        btnReset.interactable = false;

        result.text = "Result";
        ipfVarA.text = "0";
        ipfVarB.text = "0";
    }

}
