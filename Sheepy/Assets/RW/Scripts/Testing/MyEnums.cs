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
    //модификтор_доступа enum имя : тип
    //{
    //    имя1 = значение1,
    //    имя2 = значение2,
    //}
    void Start()
    {
        StudentsAge = StudentsAge.AlexK;
        print(StudentsAge.AlexK);
        
    }

   
}
