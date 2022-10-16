using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadExample : MonoBehaviour
{

    void Start()
    {
        FloatExample();
        IntArrayExample();
        ListExample();
        PersonExample();
    }

    void FloatExample()
    {
        string floatPath = "float.data";
        float f = 3.632f;
        
        // save float 
        SaveLoadSystem.SaveData<float>(f, floatPath);

        // load float
        float loadedFloat = SaveLoadSystem.LoadData<float>(floatPath);
        print(loadedFloat);
    }
    
    void IntArrayExample()
    {
        string intArrPath = "intArr.data";
        int[] intArr = new int[4] { 5, 9, 2, 1 };
        
        // save int array
        SaveLoadSystem.SaveData<int[]>(intArr, intArrPath);

        // load int array
        int[] LoadedIntArr = SaveLoadSystem.LoadData<int[]>(intArrPath);

        // print loaded arr   
        for (int i = 0; i < LoadedIntArr.Length; i++)
        {
            print(LoadedIntArr[i]);
        }
        
    }

    void ListExample()
    {
        string path = "list.data";
        List<string> stringList = new List<string>() { "Unity", "Shader", "Blender", "Animator"};
        
        // save string list 
        SaveLoadSystem.SaveData<List<string>>(stringList, path);

        // load string list
        List<string> loadedStringList = SaveLoadSystem.LoadData<List<string>>(path);

        // print string list        
        foreach (var str in loadedStringList)
        {
            print(str);
        }
    }
    

    void PersonExample()
    {
        string path = "person.data";
        Person p = new Person("Mike", 5244842);
        
        // save Person class 
        SaveLoadSystem.SaveData<Person>(p, path);

        // load Person class
        Person pl = SaveLoadSystem.LoadData<Person>(path);
        if (pl != null)
            print(string.Concat(pl.personName, " : ", pl.personNumber));
    }

}




[System.Serializable]
public class Person
{
    public string personName;
    public int personNumber;

    public Person(string personName, int personId) 
    {
        this.personName = personName;
        this.personNumber = personId;
    }
}