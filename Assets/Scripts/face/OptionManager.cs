using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class OptionManager : MonoBehaviour
{
    [SerializeField] List<Sprite> OptionsItem = new List<Sprite>();
    [SerializeField] OptionButton[] optionButtons;
    [SerializeField] NextButton nextBtn;
    [SerializeField] GameObject show;
    bool checkOptionCreat;

    public bool CheckOptionCreat { get => checkOptionCreat; set => checkOptionCreat = value; }

   
    public virtual void Show()
    {
        
        if (OptionsItem.Count > 0)
        {
            int i = 0;
            foreach (var itemp in OptionsItem)
            {
                optionButtons[i].SetSprite(itemp);
                optionButtons[i].CompBtn?.onClick.RemoveAllListeners();
                 optionButtons[i].CompBtn?.onClick.AddListener(() => Instance(itemp));
                i++;
                
            }
            if(GameManager.Ins.GameState == GameManager.state.OptionEye ||
                GameManager.Ins.GameState == GameManager.state.OptionMouth ||
                GameManager.Ins.GameState == GameManager.state.OptionAcc)
            {
                optionButtons[0].CompBtn?.onClick.RemoveAllListeners();
                optionButtons[0].CompBtn?.onClick.AddListener(() => None());
            }

        }
       

    }
    void None()
    {
        show.gameObject.SetActive(false);
        nextBtn.ShowBtn(true);
        checkOptionCreat = false;
    }
    private void Instance( Sprite itemp)
    {
        AudioController.Ins.PlaySound(AudioController.Ins.clickOption);
        show.gameObject.SetActive(true);
        show.GetComponent<Image>().sprite = itemp;
        nextBtn.ShowBtn(true);
        checkOptionCreat = true;
        if(GameManager.Ins.GameState == GameManager.state.OptionBody)
        {
           nextBtn.Done.text = "Done";
        }
    }
}
