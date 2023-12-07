using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsBody : OptionManager
{
    [SerializeField] GameObject showFace;
   // [SerializeField] GameObject showBody;

    bool active = false;
    private void Update()
    {
        if (GameManager.Ins.GameState == GameManager.state.OptionBody && GameManager.Ins.Check == true)
        {
            Show();
            GameManager.Ins.Check = false;
            showFace.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            if(active == false)
            {
                showFace.transform.position = showFace.transform.position + new Vector3(0, 0.8f, 0);
                active = true;
            }

        }
    }
   
    public override void Show()
    {
        base.Show();
    }
}
