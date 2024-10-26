//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Material materialPaint;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(this);
        }
    }
    public void ChangeColor(Color newColor) 
    {
        materialPaint.SetColor("_Color",newColor);
    }
}
