using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] starPlaceholders;

    public Sprite iconStarYellow;

    public Sprite iconStarYellow2;

    public Sprite iconStarYellow3;

    public Sprite iconStarYellow4;

    public Sprite iconStarGrey;

    public void OnChangeStarTotal(int starTotal)
    {
        for (int i = 0; i < starPlaceholders.Length; ++i)
        {
            if (i < starTotal)
                starPlaceholders[i].sprite = iconStarYellow;
            else
                starPlaceholders[i].sprite = iconStarGrey;
        }
    }
}
