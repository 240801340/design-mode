using UnityEngine;
using UnityEngine.EventSystems;

public class EventClick : MonoBehaviour, IPointerClickHandler
{

    //����һ����ɫ ������֮ǰ����ɫ 
    Color color;
    public void OnPointerClick(PointerEventData eventData)
    {
        print("����ˣ���" + this.name);
        color = transform.GetComponent<MeshRenderer>().material.color;
        transform.GetComponent<MeshRenderer>().material.color = Color.red;

    }

}
