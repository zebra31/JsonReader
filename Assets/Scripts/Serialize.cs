using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using LitJson;

public class Serialize : MonoBehaviour {
    void Start () {
        var textAsset = Resources.Load("snippet") as TextAsset;
        // var textAsset = Resources.Load("sample") as TextAsset;
        var jsonText = textAsset.text;
        
        Model model = JsonMapper.ToObject<Model>(jsonText);
        PropertyInfo[] infoModel = model.GetType().GetProperties();
        foreach (PropertyInfo im in infoModel) {
            // Debug.Log(im.PropertyType);
            // Debug.Log(im.GetValue(model,null).prefix);
            // object ouch = im.GetValue(model,null);
            Debug.Log(im.ToString());
            // Debug.Log(im.GetType().GetProperty("prefix"));
            // MethodInfo method = typeof(im.GetType).GetMethod("prefix");
            // string hoge = "hogehoge";
            // MethodInfo method = typeof(string).GetMethod("ToUpper");
            // string hogeUpper = method.Invoke(hoge, null).ToString();
            // Debug.Log(hoge);
            // Debug.Log(hogeUpper);
            // Debug.Log(method.Name);
            // Debug.Log(im.GetType().GetProperty(im.Name));
            // Debug.Log(im.GetType().GetProperty(ouch.ToString()));
            // Debug.Log(ouch.ToString());
            // PropertyInfo[] infoStruct = im.GetValue(model,null);
            // Debug.Log(infoStruct);
        }
    }
}


