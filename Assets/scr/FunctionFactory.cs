public static class FunctionFactory
{
    public static FunctionTemplate CreateFunctionFilter(Function fun)
    {
        switch(fun.category)
        {
            case FunctionType.Coseno:
                return new Coseno(fun);
            case FunctionType.Seno:
                return new Seno(fun);
            case FunctionType.Cuadrado:
                return new Cuadrado(fun);
            case FunctionType.Sierra:
                return new Sierra(fun);
        }
        return null;
    }
}