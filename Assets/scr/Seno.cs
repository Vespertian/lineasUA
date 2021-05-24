using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seno: FunctionTemplate
{

    public float amplitud = 1;
    public float periodo = 1;
    public float fase = 1;

    public Seno(Function fun)
    {
         this.amplitud = fun.amplitud;
         this.periodo = fun.periodo;
         this.fase = fun.fase;
}

    public float Evaluate (float n)
    {
        return amplitud * Mathf.Sin(periodo*n + fase);
    }
}