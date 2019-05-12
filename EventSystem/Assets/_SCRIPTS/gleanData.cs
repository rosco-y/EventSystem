using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class gleanData : MonoBehaviour, ISubmitHandler

{
    public TMP_InputField _tmpNameField;

    string _userName;

    public void GetName()
    {
        _userName = _tmpNameField.text;

        print($"This coming along most wonderfully, {_userName}.\n You are truly becoming more interactive in UNITY!!");
    }

    public void OnSubmit(BaseEventData eventData) => throw new System.NotImplementedException();
}
