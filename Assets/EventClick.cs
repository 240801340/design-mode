using UnityEngine;
using UnityEngine.EventSystems;
using System.Runtime.InteropServices;
public class EventClick : MonoBehaviour, IPointerClickHandler
{


    [DllImport("__Internal")]
    private static extern void Hello(string str);

    public void OnPointerClick(PointerEventData eventData)
    {
        Hello(this.transform.parent.gameObject.name);
        Debug.Log("** ��������:" + this.transform.parent.gameObject.name);


        if (NewBehaviourScript.iscolored == false)  //Ҫ��֮ǰ��ûͿɫ�Ļ�
        {
            NewBehaviourScript.iscolored = true;
            NewBehaviourScript.tf = transform;  //�������
            NewBehaviourScript.color = transform.GetComponent<MeshRenderer>().material.color;//������ɫ
            transform.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else     //Ҫ��֮ǰ�Ѿ�Ϳ��ɫ��
        {
            
            NewBehaviourScript.tf.GetComponent<MeshRenderer>().material.color = NewBehaviourScript.color;//��ԭ֮ǰ����ɫ

            NewBehaviourScript.color = transform.GetComponent<MeshRenderer>().material.color;//������ɫ
            
            
            transform.GetComponent<MeshRenderer>().material.color = Color.red;
            NewBehaviourScript.tf = transform;  //�������
        }
        
        
  
    }

}
