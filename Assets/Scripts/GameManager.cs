using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] Dialog menuDialog;
    [SerializeField] Dialog gamePlayDialog;
    [SerializeField] Dialog complete;
    [SerializeField] Dialog bot;
    [SerializeField] HeadController head;
    [SerializeField] EyeController eye;
    [SerializeField] MouthController mouth;
    [SerializeField] AccController acc;
    [SerializeField] BodyController body;
    [SerializeField] state gameState;
    [SerializeField] NextButton nextBtn;
    [SerializeField] PrevBtn prevBtn;
    [SerializeField] bool check = true;
    [SerializeField] ListVideos videos;
    [SerializeField] OptionEyeManager eyeOpt;

    public state GameState { get => gameState; }
    public bool Check { get => check; set => check = value; }

    public override void Awake()
    {
        MakeSingleton(false);
        gameState = state.menu;
    }
    public void HomeBtn()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void StartBtn()
    {
        menuDialog.Show(false);
        gamePlayDialog.Show(true);
        nextBtn.ShowBtn(false);
        head.ChangeIcon1();
        gameState = state.OptionHead;
        bot.Show(true);
        prevBtn.ShowBtn(false);
        AudioController.Ins.PlaySound(AudioController.Ins.start_Btn);
        AudioController.Ins.PlayBackgroundMusic();
    }
    public void PrevBtn()
    {
        switch (gameState)
        {

            case state.OptionBody:
                gameState = state.OptionAcc;
                acc.ChangeIcon1();
                body.DefualtfIcon();
                
                check = true;
                break;
            case state.OptionAcc:
                gameState = state.OptionMouth;
                mouth.ChangeIcon1();
                acc.DefualtfIcon();
                check = true;
               
                break;
            case state.OptionMouth:
                gameState = state.OptionEye;
                eye.ChangeIcon1();
                mouth.DefualtfIcon();
                check = true;

                break;
            case state.OptionEye:
                gameState = state.OptionHead;
                head.ChangeIcon1();
                eye.DefualtfIcon();
                check = true;
                // prevBtn.Active(false);
                prevBtn.ShowBtn(false);
                break;
        }
        AudioController.Ins.PlaySound(AudioController.Ins.next_Btn);
        nextBtn.Done.text = "Next";
    }
    public void NextBtn()
    {
        switch (gameState)
        {

            case state.OptionHead:
                gameState = state.OptionEye;
                check = true;

                eye.ChangeIcon1();
                head.ChangeIconComplete();
                nextBtn.ShowBtn(false);
                prevBtn.ShowBtn(true);
                break;
            case state.OptionEye:
                gameState = state.OptionMouth;
                check = true;
                mouth.ChangeIcon1();
                eye.ChangeIconComplete();
                //if (eyeOpt.CheckOptionCreat == true)
                //{
                //    nextBtn.ShowBtn(true);
                //}
                //else
                //{
                //    nextBtn.ShowBtn(false);

                //}
                nextBtn.ShowBtn(false);
                prevBtn.ShowBtn(true);
                break;
            case state.OptionMouth:
                gameState = state.OptionAcc;
                check = true;

                acc.ChangeIcon1();
                mouth.ChangeIconComplete();
                nextBtn.ShowBtn(false);
                prevBtn.ShowBtn(true);
                break;
            case state.OptionAcc:
                gameState = state.OptionBody;
                check = true;

                acc.ChangeIconComplete();
                body.ChangeIcon1();
                nextBtn.ShowBtn(false);
                prevBtn.ShowBtn(true);
                break;
            case state.OptionBody:
                Debug.Log("complete");
                gameState = state.complete;
                bot.Show(false);
                videos.RandomVideo();
                complete.Show(true);
                AudioController.Ins.PlaySound(AudioController.Ins.complete);
                break;
        }
        if (gameState == state.complete)
        {
            AudioController.Ins.PlaySound(AudioController.Ins.done_Btn);
        }
        else
        {
            AudioController.Ins.PlaySound(AudioController.Ins.next_Btn);
        }

    }
    public enum state
    {
        menu,
        OptionHead,
        OptionEye,
        OptionMouth,
        OptionAcc,
        OptionBody,
        complete
    }
}
