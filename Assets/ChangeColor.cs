using UnityEngine;
using System.Collections;
public class ChangeColor : MonoBehaviour
{
    Color color;
    bool ischange = false;
    // �������
    void OnMouseOver()
    {
        if (!ischange)
        {
            color = transform.GetComponent<MeshRenderer>().material.color;
            ischange = true;
        }
        transform.GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
    //����뿪
    void OnMouseExit()
    {
        transform.GetComponent<MeshRenderer>().material.color = color;

    }
}
