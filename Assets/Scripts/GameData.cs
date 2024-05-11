using System;
using System.Collections.Generic;

[Serializable]

public class Data
{
    // 할 일 문자열 저장
    public string[] ToDoString = new string[100];
    public int size = 0;

    public void addString(string data){
        ToDoString[size] = data;
        size++;
    }

    public void editString(int index, string data){
        ToDoString[index] = data;
    }

    public string readString(int index){
        return ToDoString[index];
    }

    public void deleteString(int index){
        ToDoString[index] = "";
        size--;
    }
}