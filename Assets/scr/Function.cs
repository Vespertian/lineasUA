using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum FunctionType { Seno, Coseno, Cuadrado, Sierra };
[System.Serializable]

[CreateAssetMenu( menuName = "Function")]
public class Function : ScriptableObject
{
    public FunctionType category;
    public float amplitud = 1;
    public float periodo = 1;
    public float fase = 1;

}
