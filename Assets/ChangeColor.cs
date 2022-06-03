using UnityEngine;
using System.Collections;
public class ChangeColor : MonoBehaviour
{
    Color color;
    bool ischange = false;
    // Êó±êÐü¸¡
    void OnMouseOver()
    {
        if (!ischange)
        {
            color = transform.GetComponent<MeshRenderer>().material.color;
            ischange = true;
        }
        transform.GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
    //Êó±êÀë¿ª
    void OnMouseExit()
    {
        transform.GetComponent<MeshRenderer>().material.color = color;

    }
}
