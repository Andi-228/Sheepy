using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StudentsAge : int
{
    AlexK = 40,
    AlexR = 31,
    Veron = 14
}

public class MyEnums : MonoBehaviour
{
    //����������_������� enum ��� : ���
    //{
    //    ���1 = ��������1,
    //    ���2 = ��������2,
    //}
    void Start()
    {
        studentsAge = StudentsAge.AlexR;
        int a = (int)studentsAge;
        print(StudentsAge.AlexK);
        
    }

   
}
