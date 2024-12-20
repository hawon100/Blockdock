using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_GridSquare : UI_Base
{
    public Image normalImage;
    public List<Sprite> normalImages;

    public void SetImage(bool setFirstImage)
    {
        normalImage.GetComponent<Image>().sprite = setFirstImage ? normalImages[1] : normalImages[0];
    }

    public override bool Init()
	{
		if (base.Init() == false)
			return false;

        

        return true;
	}
}