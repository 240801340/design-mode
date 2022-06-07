using UnityEngine;
using System.Collections;
public class ChangeColor : MonoBehaviour
{
    Color color;
    bool ischange = false;
    // 鼠标悬浮     这里做了一个逻辑判断 
    void OnMouseOver()
    {
        if (!ischange)
        {
            color = transform.GetComponent<MeshRenderer>().material.color;
            ischange = true;
        }
        transform.GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
    //鼠标离开
    void OnMouseExit()
    {
        transform.GetComponent<MeshRenderer>().material.color = color;
    }
}
