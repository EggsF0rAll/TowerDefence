using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private List<Animator> _buttonList;
    [SerializeField]
    private string _appearAnimationName = "UIObjectAppear";
    [SerializeField]
    private string _disappearAnimationName = "UIObjectDisappear";

    public void ShowButton()
    {
        foreach (Animator button in _buttonList)
        {
            button.Play(_appearAnimationName);
        }
    }

       public void HideButton()
    {
        foreach (Animator button in _buttonList)
        {
            button.Play(_disappearAnimationName);
        }
    }
}
