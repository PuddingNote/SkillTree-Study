using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ablity : MonoBehaviour
{
    public string ablityName;
    public Sprite ablitySprite;

    [TextArea(1,3)]
    public string ablityDes;
    public Ablity[] previousAblity;
    public bool isUpgrade;

}
