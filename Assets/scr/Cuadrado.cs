using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadrado: FunctionTemplate
{

    public float amplitud = 1;
    public float periodo = 1;
    public float fase = 1;

    public Cuadrado(Function fun)
    {
        this.amplitud = fun.amplitud;
        this.periodo = fun.periodo;
        this.fase = fun.fase;
    }

    public float Evaluate (float n)
    {
        return fase - amplitud * Mathf.Round(n - Mathf.Floor(n));
    }
}