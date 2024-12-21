using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity.UI;
using static Define;

public class UI_GameScene : UI_Scene
{
    enum Images
    {
        Background,
        TopBackgroundPanel,
        CurrentScoreBackground,
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindImages(typeof(Images));

        return true;
    }
}