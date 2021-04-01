# CSharp.30.IDisposable

sirve para liberar memoria y mover el objeto al garbage collector
La manera de usarlo es esta:

```csharp
sing (EjemploClaseDisposable ej = new EjemploClaseDisposable())
{
    EjemploClaseDisposable.Metodo1Ejemplo();
};
```
una vez que se acaba las llaves el objeto se mueve al garbage collector

```csharp
EjemploClaseDisposable ej2 = new();
EjemploClaseDisposable.Metodo1Ejemplo();
ej2.Dispose();
```

una vez que se ejecuta ej2.Dispose(); se mueve al garbage collector
