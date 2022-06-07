using UnityEngine;
using UnityEngine.EventSystems;

public class EventClick : MonoBehaviour, IPointerClickHandler
{

    //定义一个颜色 来保存之前的颜色 
    Color color;
    public void OnPointerClick(PointerEventData eventData)
    {
        print("点击了：：" + this.name);
        color = transform.GetComponent<MeshRenderer>().material.color;
        transform.GetComponent<MeshRenderer>().material.color = Color.red;

    }

}
