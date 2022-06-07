using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //定义一个全局变量来看看是否被涂色
    public static bool iscolored = false;
    //定义一个组件对象来保存
    public static Transform tf;
    //定义一个颜色 来保存之前的颜色(老组件) 
    public static Color color;
}
